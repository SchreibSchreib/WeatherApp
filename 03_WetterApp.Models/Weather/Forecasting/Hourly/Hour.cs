using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Weather.Forecasting.Hourly
{
    public class Hour
    {
        [JsonPropertyName("time_epoch")]
        public int TimeEpoch { get; set; }

        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("temp_c")]
        public decimal TemperatureCelsius { get; set; }

        [JsonPropertyName("temp_f")]
        public decimal TemperatureFahrenheit { get; set; }

        [JsonPropertyName("condition:text")]
        public string? ConditionText { get; set; }

        [JsonPropertyName("condition:icon")]
        public string? ConditionIcon { get; set; }

        [JsonPropertyName("condition:code")]
        public int ConditionCode { get; set; }

        [JsonPropertyName("wind_mph")]
        public decimal WindMph { get; set; }

        [JsonPropertyName("wind_kph")]
        public decimal WindKph { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string? WindDirection { get; set; }

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

        [JsonPropertyName("windchill_c")]
        public decimal WindChillCelsius { get; set; }

        [JsonPropertyName("windchill_f")]
        public decimal WindChillFahrenheit { get; set; }

        [JsonPropertyName("heatindex_c")]
        public decimal HeatIndexCelsius { get; set; }

        [JsonPropertyName("heatindex_f")]
        public decimal HeatIndexFahrenheit { get; set; }

        [JsonPropertyName("dewpoint_c")]
        public decimal DewPointCelsius { get; set; }

        [JsonPropertyName("dewpoint_f")]
        public decimal DewPointFahrenheit { get; set; }

        [JsonPropertyName("will_it_rain")]
        public int WillItRain { get; set; }

        [JsonPropertyName("will_it_snow")]
        public int WillItSnow { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("vis_km")]
        public decimal VisibilityKm { get; set; }

        [JsonPropertyName("vis_miles")]
        public decimal VisibilityMiles { get; set; }

        [JsonPropertyName("chance_of_rain")]
        public int ChanceOfRain { get; set; }

        [JsonPropertyName("chance_of_snow")]
        public int ChanceOfSnow { get; set; }

        [JsonPropertyName("gust_mph")]
        public decimal WindGustMph { get; set; }

        [JsonPropertyName("gust_kph")]
        public decimal WindGustKph { get; set; }

        [JsonPropertyName("uv")]
        public decimal UVIndex { get; set; }
    }
}
