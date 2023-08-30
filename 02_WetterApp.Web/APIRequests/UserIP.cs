using System.Net;

namespace _02_WetterApp.Web.APIRequests
{
    public class UserIP
    {
        public UserIP()
        {
            IpV4Address = GetIPAdress();
        }

        public string IpV4Address { get; private set; }

        private string GetIPAdress()
        {
            string ipV4Address = new WebClient().DownloadString("https://api.ipify.org");
            if (ipV4Address == null)
            {
                return "217.115.10.131"; //Berlin
            }
            return ipV4Address;
        }
    }
}
