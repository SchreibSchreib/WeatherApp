using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.APIConnections;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class ProcessLocationData
    {
        public ProcessLocationData()
        {
            _jsonLocationData = new LocationData(new UserIP(), new GeolocationAPIKey()).JsonContent;
        }

        private string _jsonLocationData;

    }
}
