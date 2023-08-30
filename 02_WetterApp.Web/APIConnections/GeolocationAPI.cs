using _02_WetterApp.Web.APIRequests;

namespace _02_WetterApp.Web.APIConnections
{
    public class GeolocationAPI
    {
        public GeolocationAPI()
        {
            Key = GetKey();
        }

        public string Key { get; private set; }

        private string GetKey()
        {
            IConfiguration secretApi = new ConfigurationBuilder().AddUserSecrets<GetLocation>().Build();

            if (secretApi == null || secretApi["ApiKey"] == null)
            {
                throw new NullReferenceException();
            }

            return secretApi["ApiKey"]!;
        }
    }
}
