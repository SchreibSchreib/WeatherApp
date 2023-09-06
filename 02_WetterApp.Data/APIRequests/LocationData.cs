using _02_WetterApp.Data.APIConnections;
using IPGeolocation;
using System.Diagnostics;

namespace _02_WetterApp.Data.APIRequests
{
    public class LocationData
    {
        public LocationData(UserIP ipAddress, GeolocationAPIKey geolocationAPI)
        {
            _ipAddress = ipAddress;
            _apiKey = geolocationAPI.Get;
            JsonContent = GetJsonContent();
        }

        private readonly UserIP _ipAddress;
        private readonly string _apiKey;

        public Dictionary<string, string> JsonContent { get; private set; }

        private Dictionary<string, string> GetJsonContent()
        {
            Dictionary<string, string> geoData = new Dictionary<string, string>();
            try
            {
                IPGeolocationAPI api = new IPGeolocationAPI(_apiKey);
                GeolocationParams geoParams = new GeolocationParams();
                geoParams.SetIPAddress(_ipAddress.IpV4Address);
                geoParams.SetFields(
                    "country_name," +
                    "city," +
                    "country_capital," +
                    "currency," +
                    "time_zone");

                Geolocation geolocation = api.GetGeolocation(geoParams);

                if (geolocation.GetStatus() == 200)
                {
                    geoData.Add("Country", geolocation.GetCountryName());
                    geoData.Add("Capital", geolocation.GetCountryCapital());
                    geoData.Add("City", geolocation.GetCity());
                    geoData.Add("Currency", geolocation.GetCurrency().GetName());
                    geoData.Add("TimeZone", geolocation.GetTimezone().GetName());

                    return geoData;
                }
                else
                {
                    geoData = GetDefaultGeoData();

                    return geoData;
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Connection to IP-Geodata failed");
                Debug.WriteLine("Using default values");

                geoData = GetDefaultGeoData();

                return geoData;
            }
        }

        private Dictionary<string, string> GetDefaultGeoData()
        {
            Dictionary<string, string> defaultGeoData = new Dictionary<string, string>
            {
                { "Country", "Germany" },
                { "Capital", "Berlin" },
                { "City", "Berlin" },
                { "Currency", "Euro" },
                { "TimeZone", "EU" }
            };

            return defaultGeoData;
        }
    }
}
