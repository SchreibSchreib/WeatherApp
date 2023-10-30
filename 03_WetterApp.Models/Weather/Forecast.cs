using _03_WetterApp.Models.Weather.Forecasting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather
{
    public class Forecast
    {
        [JsonPropertyName("forecastday")]
        public List<ForecastDay> ForecastDays { get; set; }
    }
}
