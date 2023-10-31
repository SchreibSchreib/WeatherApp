using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;

namespace _02_WetterApp.Data
{
    internal class WeatherDataProcessor
    {
        private FileInformation _fileInformation;
        private string _jsonContent;
        private IReadeable _readeable;
        private IWriteable _writeable;

        public WeatherDataProcessor(FileInformation fileInformation, string jsonContent)
        {
            _fileInformation = fileInformation;
            _jsonContent = jsonContent;
        }

        public CurrentWeather GetCurrentWeather() => _readeable.CurrentFromJson(_fileInformation.ForCurrent);

        public Forecast GetForecast() => _readeable.ForecastFromJson(_fileInformation.ForForecast);

        public void SafeCurrentWeather()
        {
            _writeable.WriteCurrentToJson(_fileInformation.ForCurrent, _jsonContent);
        }

        public void SafeForecast()
        {
            _writeable.WriteForecastToJson(_fileInformation.ForForecast, _jsonContent);
        }
    }
}
