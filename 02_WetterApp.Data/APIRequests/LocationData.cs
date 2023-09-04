using _02_WetterApp.Data.APIConnections;

namespace _02_WetterApp.Data.APIRequests
{
    public class LocationData
    {
        public LocationData(UserIP ipAddress, GeolocationAPIKey geolocationAPI)
        {
            _ipAddress = ipAddress;
            _apiKey = geolocationAPI.Get;
            JsonContent = GetJsonContent().Result;
        }

        private readonly UserIP _ipAddress;
        private readonly string _apiKey;

        public string JsonContent { get; private set; }

        private async Task<string> GetJsonContent()
        {
            using (HttpClient client = new HttpClient())
            {
                
                string url = $"https://api.ipgeolocation.io/ipgeo?apiKey={_apiKey}&ip={_ipAddress.IpV4Address}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"API request failed with status code: {response.StatusCode}");
                }
            }
        }
    }
}
