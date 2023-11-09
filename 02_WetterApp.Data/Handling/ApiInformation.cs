using _03_WetterApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Handling
{
    public class ApiInformation
    {
        public string UrlCurrent { get; }
        public string UrlForecast { get; }
        private User _currentUser;
        private string? _apiKey;

        public ApiInformation(User currentUser, IConfiguration config)
        {
            _currentUser = currentUser;
            _apiKey = config["ApiKeyWeatherApi"];
            UrlCurrent = GetCurrentUrl();
            UrlForecast = GetForecastUrl();
        }

        private string GetCurrentUrl()
        {
            return $"http://api.weatherapi.com/v1/current.json?key={_apiKey}&" +
                $"q={_currentUser.CurrentLocation.UserCity.Name}&" +
                $"aqi=no";
        }

        private string GetForecastUrl()
        {
            return $"http://api.weatherapi.com/v1/forecast.json?key={_apiKey}&" +
                $"q={_currentUser.CurrentLocation.UserCity.Name}&" +
                $"days=3&" +
                $"aqi=no&" +
                $"alerts=no";
        }
    }
}
