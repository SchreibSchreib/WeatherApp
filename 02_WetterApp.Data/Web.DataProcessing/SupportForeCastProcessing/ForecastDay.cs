using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing
{
    public class ForecastDay
    {
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("date_epoch")]
        public long DateEpoch { get; set; }

        [JsonPropertyName("day")]
        public Dictionary<string, double>? Day { get; set; }

        [JsonPropertyName("astro")]
        public Dictionary<string, string>? Astro { get; set; }

        [JsonPropertyName("condition")]
        public Condition? Condition { get; set; }

        [JsonPropertyName("uv")]
        public double Uv { get; set; }
    }
}
