using _03_WetterApp.Models.Abstraction.Interfaces;

namespace _02_WetterApp.Data.Handling
{
    public class FileInformation : ITimeStampable
    {
        public string Current { get; }
        public string Forecast { get; }
        public string TimeStamp { get; }
        private string _fileCurrentWeather = "CurrentWeatherInformation.json";
        private string _fileForecastWeather = "ForecastWeatherInformation.json";
        private string _timeStamp = "Timestamp.txt";

        public FileInformation()
        {
            string filePath = GetFilePath();
            Current = Path.Combine(filePath, _fileCurrentWeather);
            Forecast = Path.Combine(filePath, _fileForecastWeather);
            TimeStamp = Path.Combine(filePath, _timeStamp);
        }

        private string GetFilePath() => Directory.GetCurrentDirectory();
    }
}