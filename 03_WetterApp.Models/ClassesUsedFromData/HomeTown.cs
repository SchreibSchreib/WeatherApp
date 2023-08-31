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

        public string City { get; set; }
        public string CountryName { get; set; }
    }
}
