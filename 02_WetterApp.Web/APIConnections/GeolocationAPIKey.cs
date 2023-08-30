using _02_WetterApp.Web.APIRequests;

namespace _02_WetterApp.Web.APIConnections
{
    public class GeolocationAPIKey
    {
        public GeolocationAPIKey()
        {
            Get = GetKey();
        }

        public string Get { get; private set; }

        private string GetKey()
        {
            IConfiguration secretApi = new ConfigurationBuilder().AddUserSecrets<LocationData>().Build();

            if (secretApi == null || secretApi["ApiKey"] == null)
            {
                throw new NullReferenceException();
            }

            return secretApi["ApiKey"]!;
        }
    }
}
