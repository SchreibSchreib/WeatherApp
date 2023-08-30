using _02_WetterApp.Web.APIConnections;

namespace _02_WetterApp.Web.UserInformation
{
    public class UserIP
    {
        public UserIP()
        {
            IpV4Adress = new Ipify().IpV4Address;
        }

        public string IpV4Adress { get; private set; }
    }
}
