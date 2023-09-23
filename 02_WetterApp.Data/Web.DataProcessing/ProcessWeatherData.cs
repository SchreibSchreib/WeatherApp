using _02_WetterApp.Data.APIRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class ProcessWeatherData
    {
        public ProcessWeatherData(WeatherApiData currentWeather)
        {
            _weatherData = currentWeather.Content;
            Temperature = _weatherData["temperature_2m"];
            ApparentTemperature = _weatherData["apparent_temperature"];
            PrecipitationPropability = _weatherData["precipitation_probability"];
            Rain = _weatherData["rain"];
            SnowFall = _weatherData["snowfall"];
            SnowDepth = _weatherData["snow_depth"];
        }

        private Dictionary<string, string> _weatherData;

        public string Temperature { get; private set; }
        public string ApparentTemperature { get; private set; }
        public string PrecipitationPropability { get; private set; }
        public string Rain { get; private set; }
        public string SnowFall { get; private set; }
        public string SnowDepth { get; private set; }

    }
}
