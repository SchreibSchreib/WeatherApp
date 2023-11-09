using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;
using System.Text.Json;

namespace _02_WetterApp.Data.Handling
{
    public class Load : IReadeable
    {
        public async Task<ForecastWeatherInformation> ForecastFromHttp(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await SendHttpRequestAsync(url);

                    return await DeserializeForecastAsync(response);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to get Weatherdata. Error: " + ex.Message);
                }
            }
        }

        public async Task<CurrentWeatherInformation> CurrentFromHttp(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await SendHttpRequestAsync(url);

                    return await DeserializeCurrentAsync(response);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to get Weatherdata. Error: " + ex.Message);
                }
            }
        }

        public CurrentWeatherInformation CurrentFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            if (jsonContent is not null)
            {
                return JsonSerializer.Deserialize<CurrentWeatherInformation>(jsonContent);
            }
            throw new NullReferenceException("Failed to to get current weather from Json file.");
        }

        public ForecastWeatherInformation ForecastFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            if (jsonContent is not null)
            {
                return JsonSerializer.Deserialize<ForecastWeatherInformation>(jsonContent);
            }
            throw new NullReferenceException("Failed to to get forecast weather from Json file.");
        }

        private async Task<HttpResponseMessage> SendHttpRequestAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    throw new HttpRequestException("HTTP-Request failed" + ex.Message);
                }
            }
        }

        private async Task<ForecastWeatherInformation> DeserializeForecastAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                ForecastWeatherInformation forecast = JsonSerializer.Deserialize<ForecastWeatherInformation>(jsonResponse);

                return forecast;
            }
            else
            {
                throw new HttpRequestException($"HTTP-Anfrage fehlgeschlagen: {response.StatusCode}");
            }
        }

        private async Task<CurrentWeatherInformation>? DeserializeCurrentAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CurrentWeatherInformation current = JsonSerializer.Deserialize<CurrentWeatherInformation>(jsonResponse);

                return current;
                
            }
            else
            {
                throw new HttpRequestException($"HTTP-Anfrage fehlgeschlagen: {response.StatusCode}");
            }
        }
    }
}

