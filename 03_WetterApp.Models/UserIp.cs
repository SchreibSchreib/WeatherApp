using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            IpV4Adress = GetPublicIpV4();
            IpV6Adress = GetPublicIpV6();
        }


        private string GetPublicIpV4()
        {
            string url = "https://api.ipify.org";
            return GetIPAddressFromURL(url);
        }

        private string GetPublicIpV6()
        {
            string url = "https://api64.ipify.org";
            return GetIPAddressFromURL(url);
        }

        private string GetIPAddressFromURL(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Fehler beim Abrufen der IP-Adresse: " + e.Message);
                return "94.134.79.147"; //Berlin IP Adress
            }
        }
    }
}
