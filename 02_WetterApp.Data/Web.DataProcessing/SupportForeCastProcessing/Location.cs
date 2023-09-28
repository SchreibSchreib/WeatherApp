using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("tz_id")]
        public string? TimeZoneId { get; set; }

        [JsonPropertyName("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }

        [JsonPropertyName("localtime")]
        public string? LocalTime { get; set; }
    }
}
