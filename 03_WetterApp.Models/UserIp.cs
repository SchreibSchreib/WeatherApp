using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _03_WetterApp.Models
{
    public class UserIp
    {
        public string IpV4Adress { get; }
        public string IpV6Adress { get; }

        public UserIp()
        {
            IpV4Adress = GetIpV4();
            IpV6Adress = GetIpV6();
        }


        private string GetIpV4()
        {
            IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork) // IPv4
                {
                    return address.ToString();
                }
            }
            return "IPv4-Adresse nicht gefunden.";
        }

        private string GetIpV6()
        {
            IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetworkV6) // IPv6
                {
                    return address.ToString();
                }
            }
            return "IPv6-Adresse nicht gefunden.";
        }
    }
}
