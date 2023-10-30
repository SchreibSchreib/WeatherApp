using _02_WetterApp.Data.Abstraction.Interfaces;
using _03_WetterApp.Models;
using _03_WetterApp.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data
{
    internal class WeatherDataProcessor
    {
        private string _filePath;
        private string _jsonContent;
        private IReadeable _readeable;
        private IWriteable _writeable;

        public WeatherDataProcessor(string filePath, string jsonContent)
        {
            _filePath = filePath;
            _jsonContent = jsonContent;
        }

        public CurrentWeather GetCurrentWeather() => _readeable.CurrentFromJson(_filePath);

        public Forecast GetForecast() => _readeable.ForecastFromJson(_filePath);

        public void SafeCurrentWeather()
        {
            _writeable.WriteCurrentToJson(_filePath, _jsonContent);
        }

        public void SafeForecast()
        {
            _writeable.WriteForecastToJson(_filePath, _jsonContent);
        }
    }
}
