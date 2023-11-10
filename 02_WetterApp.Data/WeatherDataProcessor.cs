using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;
using System.Diagnostics;

namespace _02_WetterApp.Data
{
    public class WeatherDataProcessor : IProcesseable
    {
        public CurrentWeatherInformation GetCurrentWeather { get; }
        public ForecastWeatherInformation GetForecast { get; }
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
            var currentWeatherTask = Task.Run(async () => await GetCurrentWeatherAsync());
            var forecastTask = Task.Run(async () => await GetForecastAsync());

            // Warten Sie auf das Ende der Tasks und setzen Sie die Ergebnisse
            GetCurrentWeather = currentWeatherTask.Result;
            GetForecast = forecastTask.Result;
        }

        public async Task<CurrentWeatherInformation> GetCurrentWeatherAsync()
        {
            if (true)
            {
                return await _readeable.CurrentFromHttp(_apiInformation.UrlCurrent);
            }

            //return _readeable.CurrentFromJson(_fileInformation.ForCurrent);   <--For upcoming timestamp Logic
        }

        public async Task<ForecastWeatherInformation> GetForecastAsync()
        {
            if (true)
            {
                return await _readeable.ForecastFromHttp(_apiInformation.UrlForecast);
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
