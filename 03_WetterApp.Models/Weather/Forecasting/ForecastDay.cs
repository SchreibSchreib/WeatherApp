using _03_WetterApp.Models.Weather.Forecasting.Hourly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather.Forecasting
{
    public class ForecastDay
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("date_epoch")]
        public int DateEpoch { get; set; }

        [JsonPropertyName("day")]
        public Day Day { get; set; }

        [JsonPropertyName("astro")]
        public Astro Astro { get; set; }

        [JsonPropertyName("hour")]
        public List<Hour> Hours { get; set; }
    }
}
