using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.ClassesUsingData
{
    public class WeatherData
    {
        public WeatherData(ProcessLocationData location)
        {
            Information = ProcessWeatherData.Process(new _02_WetterApp.Data.APIRequests.WeatherApiData(location));
        }
        public WeatherInformation Information { get; private set; }
    }
}
