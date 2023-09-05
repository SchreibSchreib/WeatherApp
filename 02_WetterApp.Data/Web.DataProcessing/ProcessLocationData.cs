using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.APIConnections;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class ProcessLocationData
    {
        public ProcessLocationData()
        {
            _locationData = new LocationData(new UserIP(), new GeolocationAPIKey()).JsonContent;
            Country = _locationData["Country"];
            CountryCapital = _locationData["Capital"];
            City = _locationData["City"];
            Currency = _locationData["Currency"];
            TimeZone = _locationData["TimeZone"];
        }

        private Dictionary<string, string> _locationData;

        public string Country { get; private set; }
        public string CountryCapital { get; private set; }
        public string City { get; private set; }
        public string Currency { get; private set; }
        public string TimeZone { get; private set; }
    }
}
