using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing
{
    public class Astro
    {
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        [JsonPropertyName("moonrise")]
        public string? Moonrise { get; set; }

        [JsonPropertyName("moonset")]
        public string? Moonset { get; set; }

        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get; set; }

        [JsonPropertyName("moon_illumination")]
        public string? MoonIllumination { get; set; }
    }
}
