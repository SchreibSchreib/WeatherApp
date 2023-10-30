using _03_WetterApp.Models.Weather.Current;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather
{
    public class CurrentWeather
    {
        [JsonPropertyName("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("temp_c")]
        public decimal TemperatureCelsius { get; set; }

        [JsonPropertyName("temp_f")]
        public decimal TemperatureFahrenheit { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("condition")]
        public WeatherCondition Condition { get; set; }

        [JsonPropertyName("wind_mph")]
        public decimal WindMph { get; set; }

        [JsonPropertyName("wind_kph")]
        public decimal WindKph { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDirection { get; set; }

        [JsonPropertyName("pressure_mb")]
        public decimal PressureMb { get; set; }

        [JsonPropertyName("pressure_in")]
        public decimal PressureIn { get; set; }

        [JsonPropertyName("precip_mm")]
        public decimal PrecipitationMm { get; set; }

        [JsonPropertyName("precip_in")]
        public decimal PrecipitationInches { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloud")]
        public int CloudCover { get; set; }

        [JsonPropertyName("feelslike_c")]
        public decimal FeelsLikeCelsius { get; set; }

        [JsonPropertyName("feelslike_f")]
        public decimal FeelsLikeFahrenheit { get; set; }

        [JsonPropertyName("vis_km")]
        public decimal VisibilityKm { get; set; }

        [JsonPropertyName("vis_miles")]
        public decimal VisibilityMiles { get; set; }

        [JsonPropertyName("uv")]
        public decimal UVIndex { get; set; }

        [JsonPropertyName("gust_mph")]
        public decimal WindGustMph { get; set; }

        [JsonPropertyName("gust_kph")]
        public decimal WindGustKph { get; set; }
    }
}
