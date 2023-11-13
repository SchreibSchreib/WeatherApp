using _03_WetterApp.Models.Abstraction.AbstractClasses;
using _03_WetterApp.Models.Weather.Current;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather
{
    public class CurrentWeatherInformation
    {
        [JsonPropertyName("current")]
        public CurrentWeather? Current { get; set; }
    }
}
