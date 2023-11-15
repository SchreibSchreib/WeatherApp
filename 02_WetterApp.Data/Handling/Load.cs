using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Logs;
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

            CurrentWeatherInformation? current = JsonSerializer.Deserialize<CurrentWeatherInformation>(jsonContent);
            if (current != null)
            {
                return current;
            }
            throw new NullReferenceException("Failed to to get current weather from Json file.");
        }

        public ForecastWeatherInformation ForecastFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            ForecastWeatherInformation? acutalForecast = JsonSerializer.Deserialize<ForecastWeatherInformation>(jsonContent);
            if (acutalForecast != null)
            {
                return acutalForecast;
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
                    Logger.LogException(nameof(Load), ex);
                    throw new HttpRequestException("HTTP-Request failed" + ex.Message);
                }
            }
        }

        private async Task<ForecastWeatherInformation> DeserializeForecastAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                ForecastWeatherInformation? forecast = JsonSerializer.Deserialize<ForecastWeatherInformation>(jsonResponse);

                if (forecast != null)
                {
                    return forecast;
                }
            }
            throw new JsonException("Deserialization of HttpResponse for forecast weather failed");
        }

        private async Task<CurrentWeatherInformation> DeserializeCurrentAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode && response.Content is not null)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                CurrentWeatherInformation? current = JsonSerializer.Deserialize<CurrentWeatherInformation>(jsonResponse);

                if (current != null)
                {
                    return current;
                }

            }
            throw new JsonException("Deserialization of HttpResponse for current weather failed");
        }
    }
}

