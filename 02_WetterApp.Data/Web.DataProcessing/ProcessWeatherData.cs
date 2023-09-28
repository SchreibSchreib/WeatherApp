using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public static class ProcessWeatherData
    {
        public static WeatherInformation Process(WeatherApiData weatherData)
        {
            return JsonSerializer.Deserialize<WeatherInformation>(weatherData.Content);
        }
    }

    public class Current
    {

        [JsonPropertyName("last_updated")]
        public string? LastUpdated { get; set; }

        [JsonPropertyName("temp_c")]
        public double TemperatureCelsius { get; set; }

        [JsonPropertyName("temp_f")]
        public double TemperatureFahrenheit { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("condition")]
        public Condition? Condition { get; set; }

        [JsonPropertyName("wind_mph")]
        public double WindMph { get; set; }

        [JsonPropertyName("wind_kph")]
        public double WindKph { get; set; }

        [JsonPropertyName("wind_dir")]
        public string? WindDirection { get; set; }

        [JsonPropertyName("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonPropertyName("pressure_in")]
        public double PressureIn { get; set; }

        [JsonPropertyName("precip_mm")]
        public double PrecipitationMm { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloud")]
        public int Cloud { get; set; }

        [JsonPropertyName("feelslike_c")]
        public double FeelsLikeCelsius { get; set; }

        [JsonPropertyName("feelslike_f")]
        public double FeelsLikeFahrenheit { get; set; }

        [JsonPropertyName("uv")]
        public double UV { get; set; }
    }

    public class ForeCast
    {
        [JsonPropertyName("forecastday")]
        public List<ForecastDay>? Forecastday { get; set; }
    }
}
