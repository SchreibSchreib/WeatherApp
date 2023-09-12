using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.ClassesUsedFromData
{
    public class WeatherInformation
    {
        public WeatherInformation(ProcessLocationData currentLocation)
        {
            OpenMeteoWeatherData rawWeatherData = new OpenMeteoWeatherData(currentLocation);
            _proccessedWeatherData = new ProcessWeatherData(rawWeatherData);
        }

        public ProcessWeatherData _proccessedWeatherData { get; private set; }
    }
}
