using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing;

namespace _03_WetterApp.Models.ClassesUsedFromData
{
    public class HomeTown
    {
        public HomeTown(ProcessLocationData currentLocation)
        {
            CountryName = currentLocation.Country;
            GetName = currentLocation.City;
        }

        public string CountryName { get; private set; }
        public string GetName { get; private set; }

    }
}
