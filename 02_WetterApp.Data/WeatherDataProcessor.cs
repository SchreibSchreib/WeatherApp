using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;

namespace _02_WetterApp.Data
{
    internal class WeatherDataProcessor : IProcesseable
    {
        public CurrentWeather CurrentWeather { get; }
        public Forecast Forecast { get; }
        private FileInformation _fileInformation;
        private ApiInformation _apiInformation;
        private string _jsonContent;
        private IReadeable _readeable;
        private IWriteable _writeable;

        public WeatherDataProcessor(FileInformation fileInformation,
            ApiInformation apiInformation,
            IReadeable readeable,
            IWriteable writeable,
            string jsonContent)
        {
            _fileInformation = fileInformation;
            _apiInformation = apiInformation;
            _readeable = readeable;
            _writeable = writeable;
            _jsonContent = jsonContent;
            CurrentWeather = GetCurrentWeather();
            Forecast = GetForecast();
        }

        public CurrentWeather GetCurrentWeather()
        {
            if (true)
            {
                return _readeable.CurrentFromHttp(_apiInformation.UrlCurrent);
            }

            //return _readeable.CurrentFromJson(_fileInformation.ForCurrent);   <--For upcoming timestamp Logic
        }

        public Forecast GetForecast()
        {
            if (true)
            {
                return _readeable.ForecastFromHttp(_apiInformation.UrlForecast);
            }

            //return _readeable.ForecastFromJson(_fileInformation.ForForecast);   <--For upcoming timestamp Logic
        }

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
