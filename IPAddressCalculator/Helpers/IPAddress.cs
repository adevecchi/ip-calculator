using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPAdressCalculator.Helpers
{
    public class IPAddress
    {
        public string Address { get; set; }

        public string AddressBinary { get; set; }

        public int Mask { get; set; }

        public string Netmask { get; set; }

        public string NetmaskBinary { get; set; }

        public string Wildcard { get; set; }

        public string WildcardBinary { get; set; }

        public string Class { get; set; }

        public string Range { get; set; }

        public string Network { get; set; }

        public string NetworkBinary { get; set; }

        public string Broadcast { get; set; }

        public string BroadcastBinary { get; set; }

        public string HostMin { get; set; }

        public string HostMinBinary { get; set; }

        public string HostMax { get; set; }

        public string HostMaxBinary { get; set; }

        public string HostNet { get; set; }

        public string Subnetting { get; set; }

        public string Type { get; set; }
    }
}
