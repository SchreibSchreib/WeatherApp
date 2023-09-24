using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.DefaultData
{
    internal class DefaultWeatherData
    {
        public DefaultWeatherData()
        {
            Get = GetDefaultWeather();
        }

        public string Get { get; private set; }

        private string GetDefaultWeather()
        {
            return "Huhn";
        }
    }
}
