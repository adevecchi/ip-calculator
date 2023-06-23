using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPAdressCalculator.Helpers
{
    public class IPCalculate
    {
        private int mask;
        private string ipAddress;

        private int octeto1;
        private int octeto2;
        private int octeto3;
        private int octeto4;

        public IPCalculate(string ipAddress, int mask)
        {
            this.ipAddress = ipAddress;
            this.mask = mask;

            ExtractOcteto(ipAddress);
        }

        public IPAddress GetIPCalculated()
        {
            IPAddress calculated = new IPAddress();

            calculated.Address = ipAddress;
            calculated.AddressBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(octeto1), DecToBin(octeto2), DecToBin(octeto3), DecToBin(octeto4));

            IPAdressClassAndRange(calculated);

            int[] maskOctetos = IPAddressNetmask(mask, calculated);

            calculated.Mask = mask;
            calculated.Netmask = string.Format("{0}.{1}.{2}.{3} = {4}", maskOctetos[0], maskOctetos[1], maskOctetos[2], maskOctetos[3], mask);
            calculated.NetmaskBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(maskOctetos[0]), DecToBin(maskOctetos[1]), DecToBin(maskOctetos[2]), DecToBin(maskOctetos[3]));

            int[] wildOctetos = Wildcard(maskOctetos);

            calculated.Wildcard = string.Format("{0}.{1}.{2}.{3}", wildOctetos[0], wildOctetos[1], wildOctetos[2], wildOctetos[3]);
            calculated.WildcardBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(wildOctetos[0]), DecToBin(wildOctetos[1]), DecToBin(wildOctetos[2]), DecToBin(wildOctetos[3]));

            int[] redeOctetos = Network(maskOctetos);

            calculated.Network = string.Format("{0}.{1}.{2}.{3}/{4}", redeOctetos[0], redeOctetos[1], redeOctetos[2], redeOctetos[3], calculated.Mask);
            calculated.NetworkBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(redeOctetos[0]), DecToBin(redeOctetos[1]), DecToBin(redeOctetos[2]), DecToBin(redeOctetos[3]));

            calculated.HostMin = string.Format("{0}.{1}.{2}.{3}", redeOctetos[0], redeOctetos[1], redeOctetos[2], redeOctetos[3] + 1);
            calculated.HostMinBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(redeOctetos[0]), DecToBin(redeOctetos[1]), DecToBin(redeOctetos[2]), DecToBin(redeOctetos[3] + 1));

            int[] broadOctetos = Broadcast(redeOctetos, wildOctetos);

            calculated.Broadcast = string.Format("{0}.{1}.{2}.{3}", broadOctetos[0], broadOctetos[1], broadOctetos[2], broadOctetos[3]);
            calculated.BroadcastBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(broadOctetos[0]), DecToBin(broadOctetos[1]), DecToBin(broadOctetos[2]), DecToBin(broadOctetos[3]));

            calculated.HostMax = string.Format("{0}.{1}.{2}.{3}", broadOctetos[0], broadOctetos[1], broadOctetos[2], broadOctetos[3] - 1);
            calculated.HostMaxBinary = string.Format("{0}.{1}.{2}.{3}", DecToBin(broadOctetos[0]), DecToBin(broadOctetos[1]), DecToBin(broadOctetos[2]), DecToBin(broadOctetos[3] - 1));

            calculated.HostNet = HostNet(wildOctetos[0], wildOctetos[1], wildOctetos[2], wildOctetos[3]);
            calculated.Subnetting = Subnet(calculated.Mask, calculated) != "1" ? Subnet(calculated.Mask, calculated) : "";
            calculated.Type = InternetType(calculated);

            return calculated;
        }

        private void ExtractOcteto(string ipAddress)
        {
            int countDot = 0;

            string oct1 = string.Empty;
            string oct2 = string.Empty;
            string oct3 = string.Empty;
            string oct4 = string.Empty;

            foreach (char c in ipAddress)
            {
                switch (countDot)
                {
                    case 0:
                        if (c == '.')
                            countDot++;
                        else
                            oct1 += c.ToString();
                        break;
                    case 1:
                        if (c == '.')
                            countDot++;
                        else
                            oct2 += c.ToString();
                        break;
                    case 2:
                        if (c == '.')
                            countDot++;
                        else
                            oct3 += c.ToString();
                        break;
                    case 3:
                        oct4 += c.ToString();
                        break;
                }
            }

            octeto1 = int.Parse(oct1);
            octeto2 = int.Parse(oct2);
            octeto3 = int.Parse(oct3);
            octeto4 = int.Parse(oct4);
        }

        private void IPAdressClassAndRange(IPAddress calculated)
        {
            if ((octeto1 > 0) && (octeto1 < 128))
            {
                calculated.Class = "A";
                calculated.Range = "Range: 1.xxx.xxx.xxx  to  126.xxx.xxx.xxx";
            }
            else if ((octeto1 > 127) && (octeto1 < 192))
            {
                calculated.Class = "B";
                calculated.Range = "Range: 128.xxx.xxx.xxx  to  191.xxx.xxx.xxx";
            }
            else if ((octeto1 > 191) && (octeto1 < 224))
            {
                calculated.Class = "C";
                calculated.Range = "Range: 192.xxx.xxx.xxx  to  223.xxx.xxx.xxx";
            }
            else if ((octeto1 > 223) && (octeto1 < 240))
            {
                calculated.Class = "D";
                calculated.Range = "Range: 224.xxx.xxx.xxx  to  239.xxx.xxx.xxx";
            }
            else
            {
                calculated.Class = "E";
                calculated.Range = "Range: 240.xxx.xxx.xxx  to  255.xxx.xxx.xxx";
            }
        }

        private int[] IPAddressNetmask(int mask, IPAddress calculated)
        {
            int temp = mask;

            switch (calculated.Class)
            {
                case "A": mask = mask < 8 ? 8 : temp; break;
                case "B": mask = mask < 16 ? 16 : temp; break;
                case "C": mask = mask < 24 ? 24 : temp; break;
            }

            int maskBit = mask % 8;
            int maskByte = mask / 8;

            int maskOct1 = 255;
            int maskOct2 = 0;
            int maskOct3 = 0;
            int maskOct4 = 0;

            switch (calculated.Class)
            {
                case "A":
                    if (maskByte == 1)
                    {
                        maskOct2 = (((int)Math.Pow(2, maskBit)) - 1);
                        maskOct2 <<= (8 - maskBit);
                        maskOct3 = 0;
                        maskOct4 = 0;
                    }
                    else if (maskByte == 2)
                    {
                        maskOct2 = 255;
                        maskOct3 = (((int)Math.Pow(2, maskBit)) - 1);
                        maskOct3 <<= (8 - maskBit);
                        maskOct4 = 0;
                    }
                    else if (maskByte == 3)
                    {
                        maskOct2 = 255;
                        maskOct3 = 255;
                        maskOct4 = (((int)Math.Pow(2, maskBit)) - 1);
                        maskOct4 <<= (8 - maskBit);
                    }
                    break;
                case "B":
                    maskOct2 = 255;
                    if (maskByte == 2)
                    {
                        maskOct3 = (((int)Math.Pow(2, maskBit)) - 1);
                        maskOct3 <<= (8 - maskBit);
                        maskOct4 = 0;
                    }
                    else if (maskByte == 3)
                    {
                        maskOct3 = 255;
                        maskOct4 = (ushort)(((int)Math.Pow(2, maskBit)) - 1);
                        maskOct4 <<= (8 - maskBit);
                    }
                    break;
                case "C":
                    maskOct2 = 255;
                    maskOct3 = 255;
                    maskOct4 = (((int)Math.Pow(2, maskBit)) - 1);
                    maskOct4 <<= (8 - maskBit);
                    break;
            }

            return new int[] { maskOct1, maskOct2, maskOct3, maskOct4 };
        }

        private int[] Wildcard(int[] maskOctetos)
        {
            int wildOct1 = InverteMask(DecToBin(maskOctetos[0]));
            int wildOct2 = InverteMask(DecToBin(maskOctetos[1]));
            int wildOct3 = InverteMask(DecToBin(maskOctetos[2]));
            int wildOct4 = InverteMask(DecToBin(maskOctetos[3]));

            return new int[] { wildOct1, wildOct2, wildOct3, wildOct4 };
        }

        public int[] Network(int[] maskOctetos)
        {
            int rede1 = octeto1 & maskOctetos[0];
            int rede2 = octeto2 & maskOctetos[1];
            int rede3 = octeto3 & maskOctetos[2];
            int rede4 = octeto4 & maskOctetos[3];

            return new int[] { rede1, rede2, rede3, rede4 };
        }

        private int[] Broadcast(int[] redeOctetos, int[] wildOctetos)
        {
            int broadOct1 = redeOctetos[0] | wildOctetos[0];
            int broadOct2 = redeOctetos[1] | wildOctetos[1];
            int broadOct3 = redeOctetos[2] | wildOctetos[2];
            int broadOct4 = redeOctetos[3] | wildOctetos[3];

            return new int[] { broadOct1, broadOct2, broadOct3, broadOct4 };
        }

        private string HostNet(int w1, int w2, int w3, int w4)
        {
            int count = 0;
            char c;
            string s;

            s = DecToBin(w1);

            for (int i = 0; i < 8; i++)
            {
                c = s[i];
                if (c == '1')
                    count++;
            }

            s = DecToBin(w2);

            for (int i = 0; i < 8; i++)
            {
                c = s[i];
                if (c == '1')
                    count++;
            }

            s = DecToBin(w3);

            for (int i = 0; i < 8; i++)
            {
                c = s[i];
                if (c == '1')
                    count++;
            }

            s = DecToBin(w4);

            for (int i = 0; i < 8; i++)
            {
                c = s[i];
                if (c == '1')
                    count++;
            }

            return (((int)Math.Pow(2, count)) - 2).ToString("#,#", System.Globalization.CultureInfo.InstalledUICulture);
        }

        private string Subnet(int sub, IPAddress calculated)
        {
            int subnet = 0;
            string classe = calculated.Class;

            if ((classe == "A") && (sub > 8)) 
                subnet = sub - 8;
            else if ((classe == "B") && (sub > 16))
                subnet = sub - 16;
            else if ((classe == "C") && (sub > 24))
                subnet = sub - 24;

            return ((int)Math.Pow(2, subnet)).ToString("#,#", System.Globalization.CultureInfo.InstalledUICulture);
        }

        private string InternetType(IPAddress calculated)
        {
            string type = "  ( Public Internet )";

            switch (calculated.Class)
            {
                case "A":
                    if (octeto1 == 10)
                        type = "( Private Internet )";
                    break;
                case "B":
                    if (octeto1 == 172 && (octeto2 > 15 && octeto2 < 32))
                        type = "( Private Internet )";
                    break;
                case "C":
                    if (octeto1 == 192 && octeto2 == 168)
                        type = "( Private Internet )";
                    break;
            }

            return type;
        }

        private string DecToBin(int num)
        {
            byte index = 7;
            int[] b = new int[8];
            string ret = "";

            for (byte i = 0; i < 8; i++)
                b[i] = 0;

            while (num > 0)
            {
                b[index] = num % 2;
                index--;
                num /= 2;
            }

            for (byte i = 0; i < 8; i++)
                ret += b[i].ToString();

            return ret;
        }

        private int BinToDec(string v)
        {
            int num;
            int exp = 0;
            int soma = 0;
            string numInvertido = v;

            for (byte i = 0; i < numInvertido.Length; i++)
            {
                num = Convert.ToInt32(v.Substring(i, 1));
                soma += num * (int)Math.Pow(2, exp);
                exp++;
            }

            return soma;
        }

        private int InverteMask(string r)
        {
            char c;
            string t = "";
            string iv = "";

            for (int i = 7; i >= 0; i--)
            {
                c = r[i];
                t += c.ToString();
            }

            for (byte i = 0; i < 8; i++)
            {
                c = t[i];
                if (c == '1')
                {
                    c = '0';
                    iv += c.ToString();
                }
                else
                {
                    c = '1';
                    iv += c.ToString();
                }
            }

            return BinToDec(iv);
        }
    }
}
