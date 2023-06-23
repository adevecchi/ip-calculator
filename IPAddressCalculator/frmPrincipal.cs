using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPAdressCalculator
{
    public partial class frmPrimcipal : Form
    {
        public frmPrimcipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = textBox1.Text;
                int mask = int.Parse(textBox2.Text);

                Helpers.IPAddress calculatedIP = new Helpers.IPCalculate(ipAddress, mask).GetIPCalculated();

                if (mask < 31)
                {
                    lblAddress.Text = calculatedIP.Address;
                    lblAddressBin.Text = calculatedIP.AddressBinary;

                    textBox2.Text = calculatedIP.Mask.ToString();
                    lblNetmask.Text = calculatedIP.Netmask;
                    lblNetmaskBin.Text = calculatedIP.NetmaskBinary;

                    lblWildCard.Text = calculatedIP.Wildcard;
                    lblWildcardBin.Text = calculatedIP.WildcardBinary;


                    lblClasse.Text = calculatedIP.Class;
                    lblClassRange.Text = calculatedIP.Range;

                    lblNetwork.Text = calculatedIP.Network;
                    lblNetworkBin.Text = calculatedIP.NetworkBinary;

                    lblBroadcast.Text = calculatedIP.Broadcast;
                    lblBroadcastBin.Text = calculatedIP.BroadcastBinary;
                    
                    lblHostMin.Text = calculatedIP.HostMin;
                    lblHostMinBin.Text = calculatedIP.HostMinBinary;

                    lblHostMax.Text = calculatedIP.HostMax;
                    lblHostMaxBin.Text = calculatedIP.HostMaxBinary;

                    lblHostNet.Text = calculatedIP.HostNet;

                    if (!string.IsNullOrEmpty(calculatedIP.Subnetting))
                    {
                        lblSubnetTitle.Visible = true;
                        lblSubnetValue.Text = calculatedIP.Subnetting;
                    }
                    else
                    {
                        lblSubnetTitle.Visible = false;
                        lblSubnetValue.Text = "";
                    }

                    lblTypeNet.Text = calculatedIP.Type;

                    textBox1.HideSelection = false;
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                else
                {
                    string mensagem = "O maior número permitido à Mascara de Bits é 30!\nPor Favor Digite-o navamente!!!";
                    MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch
            {
                string mensagem = "Endereço ou Mascara de bits digitados estão Incorretos!\nPor Favor Digite-os navamente!!!";
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSobre mySobre = new frmSobre();
            mySobre.ShowDialog();
            mySobre.Dispose();
        }

        private void frmPrimcipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Focused == true) 
                { 
                    textBox1.HideSelection = true; 
                    textBox2.HideSelection = false; 
                }
                else if (textBox2.Focused == true) 
                { 
                    textBox2.HideSelection = true; 
                    textBox2.SelectAll(); 
                }
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmPrimcipal_Load(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.10.2";
            textBox2.Text = "24";

            button1_Click(sender, e);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Focused == true)
            {
                textBox1.HideSelection = true;
                textBox2.HideSelection = true;
            }
            else
            {
                textBox2.HideSelection = true;
                textBox1.HideSelection = false;
                textBox1.SelectAll();
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Focused == true)
            {
                textBox2.HideSelection = true;
                textBox1.HideSelection = true;
            }
            else
            {
                textBox1.HideSelection = true;
                textBox2.HideSelection = false;
                textBox2.SelectAll();
            }
        }
    }
}
