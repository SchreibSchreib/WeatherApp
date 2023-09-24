using _02_WetterApp.Data.Web.DataProcessing;
using _03_WetterApp.Models.ClassesUsingData;

namespace _03_WetterApp.Models.ClassesUsedByUI
{
    public class User
    {
        public User()
        {
            ProcessLocationData currentLocation = new ProcessLocationData();
            Capital = new CountryCapital(currentLocation);
            HomeTown = new HomeTown(currentLocation);
            Weather = new WeatherInformation(currentLocation);

            ActualTime = DateTime.Now;
        }

        public CountryCapital Capital { get; private set; }
        public HomeTown HomeTown { get; private set; }
        public WeatherInformation Weather { get; private set; }
        public DateTime ActualTime { get; private set; }

    }
}
