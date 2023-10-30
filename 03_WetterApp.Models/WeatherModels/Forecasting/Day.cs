using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.WeatherModels.Forecasting
{

    public class Day
    {
        [JsonPropertyName("maxtemp_c")]
        public decimal MaxTempCelsius { get; set; }

        [JsonPropertyName("maxtemp_f")]
        public decimal MaxTempFahrenheit { get; set; }

        [JsonPropertyName("mintemp_c")]
        public decimal MinTempCelsius { get; set; }

        [JsonPropertyName("mintemp_f")]
        public decimal MinTempFahrenheit { get; set; }

        [JsonPropertyName("avgtemp_c")]
        public decimal AvgTempCelsius { get; set; }

        [JsonPropertyName("avgtemp_f")]
        public decimal AvgTempFahrenheit { get; set; }

        [JsonPropertyName("maxwind_mph")]
        public decimal MaxWindMph { get; set; }

        [JsonPropertyName("maxwind_kph")]
        public decimal MaxWindKph { get; set; }

        [JsonPropertyName("totalprecip_mm")]
        public decimal TotalPrecipitationMm { get; set; }

        [JsonPropertyName("totalprecip_in")]
        public decimal TotalPrecipitationInches { get; set; }

        [JsonPropertyName("avgvis_km")]
        public decimal AvgVisibilityKm { get; set; }

        [JsonPropertyName("avgvis_miles")]
        public decimal AvgVisibilityMiles { get; set; }

        [JsonPropertyName("avghumidity")]
        public int AvgHumidity { get; set; }

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
