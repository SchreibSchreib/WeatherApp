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
        private ITimeStampable _fileInformation;
        private IInformationable _apiInformation;
        private IReadeable _readeable;
        private IWriteable _writeable;
        private string[]? _jsonContent;

        public WeatherDataProcessor(ITimeStampable fileInformation,
            IInformationable apiInformation,
            IReadeable readeable,
            IWriteable writeable)
        {
            _fileInformation = fileInformation;
            _apiInformation = apiInformation;
            _readeable = readeable;
            _writeable = writeable;
            _jsonContent = GetJsonContent();
            Task<CurrentWeatherInformation> currentWeatherTask = Task.Run(async () => await GetCurrentWeatherAsync());
            Task<ForecastWeatherInformation> forecastTask = Task.Run(async () => await GetForecastAsync());

            // Warten Sie auf das Ende der Tasks und setzen Sie die Ergebnisse
            GetCurrentWeather = currentWeatherTask.Result;
            GetForecast = forecastTask.Result;
        }

        public async Task<CurrentWeatherInformation> GetCurrentWeatherAsync()
        {
            if (true)
            {
                return await _readeable.CurrentFromHttp(_apiInformation.Current);
            }

            //return _readeable.CurrentFromJson(_fileInformation.ForCurrent);   <--For upcoming timestamp Logic
        }

        public async Task<ForecastWeatherInformation> GetForecastAsync()
        {
            if (true)
            {
                return await _readeable.ForecastFromHttp(_apiInformation.Forecast);
            }

            //return _readeable.ForecastFromJson(_fileInformation.ForForecast);   <--For upcoming timestamp Logic
        }

        public void SafeCurrentWeather()
        {
            if (_jsonContent != null)
            {
                _writeable.WriteCurrentToJson(_fileInformation.Current, _jsonContent[0]);
            }
        }

        public void SafeForecast()
        {
            if (_jsonContent != null)
            {
                _writeable.WriteForecastToJson(_fileInformation.Forecast, _jsonContent[1]);
            }
        }

        private string[]? GetJsonContent()
        {
            if (FilesExist())
            {
                string[] jsonContent = new string[2];
                jsonContent[0] = File.ReadAllText(_fileInformation.Current);
                jsonContent[1] = File.ReadAllText(_fileInformation.Forecast);

                return jsonContent;
            }

            Debug.WriteLine("No Json files found...returning null");
            return null;
        }

        private bool FilesExist() => File.Exists(_fileInformation.Current) && File.Exists(_fileInformation.Forecast);

    }
}
