using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing;

namespace _03_WetterApp.Models.ClassesUsedFromData
{
    public class HomeTown
    {
        public HomeTown()
        {
            ProcessLocationData currentHome = new ProcessLocationData();
        }

        public string CountryName { get; private set; }
        public string City { get; private set; }

    }
}
