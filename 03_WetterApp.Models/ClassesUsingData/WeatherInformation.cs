using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.ClassesUsingData
{
    public class WeatherInformation
    {
        public WeatherInformation(ProcessLocationData currentLocation)
        {
            WeatherApiData rawWeatherData = new WeatherApiData(currentLocation);
            _proccessedWeatherData = new ProcessWeatherData(rawWeatherData);
            Current = _proccessedWeatherData.GetCurrent();
            ForeCast = _proccessedWeatherData.GetForecast();
        }

        private ProcessWeatherData _proccessedWeatherData;

        public Current Current { get; private set; }
        public ForeCast ForeCast { get; private set; }
    }
}
