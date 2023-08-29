using System.Net;

namespace _02_WetterApp.Web.LocationInformation
{
    public class Location
    {
        public Location()
        {
            _ipAdress = getIPAdsress();
            InitializeAsync();
        }

        private string _ipAdress;

        public string Name { get; private set; }

        private async void InitializeAsync()
        {
            string resultLocation = await GetLocation();
            Name = resultLocation;
        }

        private async Task<string> GetLocation()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(_ipAdress);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        private string getIPAdsress()
        {
            string ipV4Address = new WebClient().DownloadString("https://api.ipify.org");
            if (ipV4Address == null )
            {
                return "217.115.10.131"; //Berlin
            }
            return ipV4Address;
        }
    }
}
