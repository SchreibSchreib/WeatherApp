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

        public Locator(UserIp currentUserIp)
        {
            _ipV4 = currentUserIp.IpV4Adress;
            _ipV6 = currentUserIp.IpV6Adress;
            _ipResponse = GetIpInformation().Result;
        }

        private async Task<IPResponse> GetIpInformation()
        {
            IPinfoClient client = GetClient();
            IPResponse ipResponse = await client.IPApi.GetDetailsAsync(_ipV4);
            return ipResponse;
        }

        private IPinfoClient GetClient()
        {
            return new IPinfoClient.Builder()
                .AccessToken("c0a7f5306473a6")
                .Build();
        }

        private string GetToken()
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .AddUserSecrets<string>()
            .Build();

            return configuration["ApiKeyIpInfo"];
        }

        public Country LocateCountry()
        {
            throw new NotImplementedException();
        }

        public City LocateCity()
        {
            throw new NotImplementedException();
        }

        public Region LocateRegion()
        {
            throw new NotImplementedException();
        }
    }
}
