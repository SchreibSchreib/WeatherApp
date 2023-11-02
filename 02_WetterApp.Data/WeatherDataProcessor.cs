using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;
using System.Diagnostics;

namespace _02_WetterApp.Data
{
    public class WeatherDataProcessor : IProcesseable
    {
        public CurrentWeather CurrentWeather { get; }
        public Forecast Forecast { get; }
        private FileInformation _fileInformation;
        private ApiInformation _apiInformation;
        private string[]? _jsonContent;
        private IReadeable _readeable;
        private IWriteable _writeable;

        public WeatherDataProcessor(FileInformation fileInformation,
            ApiInformation apiInformation,
            IReadeable readeable,
            IWriteable writeable)
        {
            _fileInformation = fileInformation;
            _apiInformation = apiInformation;
            _readeable = readeable;
            _writeable = writeable;
            _jsonContent = GetJsonContent();
            CurrentWeather = GetCurrentWeather();
            Forecast = GetForecast();
        }

        public CurrentWeather GetCurrentWeather()
        {
            if (true)
            {
                return _readeable.CurrentFromHttp(_apiInformation.UrlCurrent).Result;
            }

            //return _readeable.CurrentFromJson(_fileInformation.ForCurrent);   <--For upcoming timestamp Logic
        }

        public Forecast GetForecast()
        {
            if (true)
            {
                return _readeable.ForecastFromHttp(_apiInformation.UrlForecast).Result;
            }

            //return _readeable.ForecastFromJson(_fileInformation.ForForecast);   <--For upcoming timestamp Logic
        }

        public void SafeCurrentWeather()
        {
            _writeable.WriteCurrentToJson(_fileInformation.ForCurrent, _jsonContent[0]);
        }

        public void SafeForecast()
        {
            _writeable.WriteForecastToJson(_fileInformation.ForForecast, _jsonContent[1]);
        }

        private string[]? GetJsonContent()
        {
            if (FilesExist())
            {
                string[] jsonContent = new string[2];
                jsonContent[0] = File.ReadAllText(_fileInformation.ForCurrent);
                jsonContent[1] = File.ReadAllText(_fileInformation.ForForecast);

                return jsonContent;
            }

            Debug.WriteLine("No Json files found...returning null");
            return null;
        }

        private bool FilesExist() => File.Exists(_fileInformation.ForCurrent) && File.Exists(_fileInformation.ForForecast);

    }
}
