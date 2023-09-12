using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _02_WetterApp.Data.APIRequests
{
    internal class OpenMeteoWeatherData
    {
        public OpenMeteoWeatherData(ProcessLocationData currentData)
        {
            _latitude = currentData.Latitude;
            _longitude = currentData.Longitude;
            JsonContent = GetContent().Result;
        }

        private string _latitude;
        private string _longitude;

        public string JsonContent { get; private set; }

        private async Task<string> GetContent()
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={_latitude}&longitude={_longitude}&hourly=temperature_2m,apparent_temperature,precipitation_probability,rain,snowfall,snow_depth";

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Successful connected to OpenMeteo");
                    Debug.WriteLine("Getting WeatherData");
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Debug.WriteLine("Connection to OpenMeteo failed");
                    Debug.WriteLine("Using default weather instead");
                    string defaultWeatherData = "{'temperature_2m': 20, 'apparent_temperature': 20, 'precipitation_probability': 0, 'rain': 0, 'snowfall': 0, 'snow_depth': 0}";
                    return defaultWeatherData;
                }
            }
        }
    }
}

