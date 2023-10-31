namespace _02_WetterApp.Data.Handling
{
    internal class FileInformation
    {
        public string ForCurrent { get; }
        public string ForForecast { get; }
        private string _fileCurrentWeather = "CurrentWeatherInformation.json";
        private string _fileForecastWeather = "ForecastWeatherInformation.json";

        public FileInformation()
        {
            ForCurrent = Path.Combine(GetFilePath(), _fileCurrentWeather);
            ForForecast = Path.Combine(GetFilePath(), _fileForecastWeather);
        }

        private string GetFilePath() => Directory.GetCurrentDirectory();
    }
}