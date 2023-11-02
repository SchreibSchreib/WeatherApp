using _03_WetterApp.Models;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;
using System.Text.Json;

namespace _02_WetterApp.Data.Handling
{
    public class Load : IReadeable
    {
        public async Task<Forecast> ForecastFromHttp(string url)
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

        public async Task<CurrentWeather> CurrentFromHttp(string url)
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

        public CurrentWeather CurrentFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            if (jsonContent is not null)
            {
                return JsonSerializer.Deserialize<CurrentWeather>(jsonContent);
            }
            throw new NullReferenceException("Failed to to get current weather from Json file.");
        }

        public Forecast ForecastFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            if (jsonContent is not null)
            {
                return JsonSerializer.Deserialize<Forecast>(jsonContent);
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

        private async Task<Forecast> DeserializeForecastAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    Forecast forecast = await JsonSerializer.DeserializeAsync<Forecast>(responseStream);
                    return forecast;
                }
            }
            else
            {
                throw new HttpRequestException($"HTTP-Anfrage fehlgeschlagen: {response.StatusCode}");
            }
        }

        private async Task<CurrentWeather>? DeserializeCurrentAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                using (Stream responseStream = await response.Content.ReadAsStreamAsync())
                {
                    CurrentWeather current = await JsonSerializer.DeserializeAsync<CurrentWeather>(responseStream);
                    return current;
                }
            }
            else
            {
                throw new HttpRequestException($"HTTP-Anfrage fehlgeschlagen: {response.StatusCode}");
            }
        }
    }
}

