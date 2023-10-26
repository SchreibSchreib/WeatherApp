using _03_WetterApp.Models.Abstraction.Interfaces;

namespace _03_WetterApp.Models
{
    internal class Locator : ILocateable<object>
    {
        private string _ipV4;
        private string _ipV6;

        public Locator(UserIp currentUserIp)
        {
            _ipV4 = currentUserIp.IpV4Adress;
            _ipV6 = currentUserIp.IpV6Adress;
        }

        public object Locate(object currentObject)
        {
            throw new NotImplementedException();
        }
    }
}
