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
        public int DateEpoch { get; set; }

        [JsonPropertyName("day")]
        public Day? DayData { get; set; }

        [JsonPropertyName("astro")]
        public Astro? AstroData { get; set; }

        [JsonPropertyName("hour")]
        public List<Hour>? HourData { get; set; }
    }
}
