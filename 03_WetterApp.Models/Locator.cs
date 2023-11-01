using _03_WetterApp.Models.Abstraction.Interfaces;
using IPinfo;
using IPinfo.Models;
using Microsoft.Extensions.Configuration;

namespace _03_WetterApp.Models
{
    public class Locator : ILocateable
    {
        private string _ipV4;
        private string _ipV6;
        private IPResponse _ipResponse;
        private string? _apiKey;

        public Locator(UserIp currentUserIp, IConfiguration config)
        {
            _ipV4 = currentUserIp.IpV4Adress;
            _ipV6 = currentUserIp.IpV6Adress;
            _apiKey = config["ApiKeyIpInfo"];
            _ipResponse = GetIpInformation();
        }

        private IPResponse GetIpInformation()
        {
            IPinfoClient client = GetClient();
            IPResponse ipResponse = client.IPApi.GetDetails(_ipV4);
            return ipResponse;
        }

        private IPinfoClient GetClient()
        {
            return new IPinfoClient.Builder()
                .AccessToken(_apiKey)
                .Build();
        }

        public Country LocateCountry() => new Country(_ipResponse.Country);
   

        public Region LocateRegion() => new Region(_ipResponse.Region);
        

        public City LocateCity() => new City(_ipResponse.City);
        

        public bool IsLocated() => _ipResponse == null;
    }
}
