using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather.Forecasting
{

    public class Day
    {
        [JsonPropertyName("maxtemp_c")]
        public double MaxTempCelsius { get; set; }

        [JsonPropertyName("maxtemp_f")]
        public double MaxTempFahrenheit { get; set; }

        [JsonPropertyName("mintemp_c")]
        public double MinTempCelsius { get; set; }

        [JsonPropertyName("mintemp_f")]
        public double MinTempFahrenheit { get; set; }

        [JsonPropertyName("avgtemp_c")]
        public double AvgTempCelsius { get; set; }

        [JsonPropertyName("avgtemp_f")]
        public double AvgTempFahrenheit { get; set; }

        [JsonPropertyName("maxwind_mph")]
        public double MaxWindMph { get; set; }

        [JsonPropertyName("maxwind_kph")]
        public double MaxWindKph { get; set; }

        [JsonPropertyName("totalprecip_mm")]
        public double TotalPrecipitationMm { get; set; }

        [JsonPropertyName("totalprecip_in")]
        public double TotalPrecipitationInches { get; set; }

        [JsonPropertyName("avgvis_km")]
        public double AvgVisibilityKm { get; set; }

        [JsonPropertyName("avgvis_miles")]
        public double AvgVisibilityMiles { get; set; }

        [JsonPropertyName("avghumidity")]
        public double AvgHumidity { get; set; }

        [JsonPropertyName("condition:text")]
        public string ConditionText { get; set; }

        [JsonPropertyName("condition:icon")]
        public string ConditionIcon { get; set; }

        [JsonPropertyName("condition:code")]
        public int ConditionCode { get; set; }

        [JsonPropertyName("uv")]
        public decimal UVIndex { get; set; }
    }
}
