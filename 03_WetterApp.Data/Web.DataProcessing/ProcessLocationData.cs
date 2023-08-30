using _02_WetterApp.Web.APIConnections;
using _02_WetterApp.Web.APIRequests;
using _02_WetterApp.Web.APIRequests;

namespace _03_WetterApp.Data.Web.DataProcessing
{
    public class ProcessLocationData
    {
        public ProcessLocationData()
        {
            _locationData = new LocationData(new UserIP(), new GeolocationAPIKey());
        }
        private LocationData _locationData;


    }
}
