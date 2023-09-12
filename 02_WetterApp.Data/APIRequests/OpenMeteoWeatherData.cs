using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace _02_WetterApp.Data.APIRequests
{
    public class OpenMeteoWeatherData
    {
        public OpenMeteoWeatherData(ProcessLocationData currentLocation)
        {
            _latitude = currentLocation.Latitude;
            _longitude = currentLocation.Longitude;
            Content = GetContent().Result;
        }

        private string _latitude;
        private string _longitude;

        public Dictionary<string, string> Content { get; private set; }

        private async Task<Dictionary<string, string>> GetContent()
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={_latitude}&longitude={_longitude}&hourly=temperature_2m,apparent_temperature,precipitation_probability,rain,snowfall,snow_depth";

            using (HttpClient client = new HttpClient())
            {

                client.Timeout = TimeSpan.FromSeconds(10);
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Successful connected to OpenMeteo");
                    Debug.WriteLine("Getting WeatherData");
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("Deserializing...");
                    Dictionary<string, string> weatherData = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                    return weatherData;
                }
                else
                {
                    Debug.WriteLine("Connection to OpenMeteo failed");
                    Debug.WriteLine("Using default weather instead");
                    Dictionary<string, string> defaultWeatherData = GetDefaultWeather();

                    return defaultWeatherData;
                }
            }
        }
        private Dictionary<string, string> GetDefaultWeather()
        {
            return new Dictionary<string, string>
            {
                {"Temperature2m", "20.0"},
                {"ApparentTemperature", "20.0"},
                {"PrecipitationProbability", "0.0"},
                {"Rain", "0.0"},
                {"Snowfall", "0.0"},
                {"SnowDepth", "0.0"}
            };
        }
    }
}

