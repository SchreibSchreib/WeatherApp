using _02_WetterApp.Web.APIConnections;
using _04_WetterApp.Models.ClassesUsedByWeb;

namespace _02_WetterApp.Web.APIRequests
{
    public class GetLocation
    {
        public GetLocation(UserIP ipAdress, GeolocationAPI geolocationAPI)
        {
            _ipAdress = ipAdress;
            _apiKey = geolocationAPI.Key;
        }

        private readonly UserIP _ipAdress;
        private readonly string _apiKey;

        public JsonContent TownInformation { get; private set; }
    }
}

