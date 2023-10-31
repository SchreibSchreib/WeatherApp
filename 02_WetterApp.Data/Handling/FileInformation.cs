namespace _02_WetterApp.Data.Handling
{
    public class FileInformation
    {
        public string ForCurrent { get; }
        public string ForForecast { get; }
        public string ForTimeStamp { get; }
        private string _fileCurrentWeather = "CurrentWeatherInformation.json";
        private string _fileForecastWeather = "ForecastWeatherInformation.json";
        private string _timeStamp = "Timestamp.txt";

        public FileInformation()
        {
            string filePath = GetFilePath();
            ForCurrent = Path.Combine(filePath, _fileCurrentWeather);
            ForForecast = Path.Combine(filePath, _fileForecastWeather);
            ForTimeStamp = Path.Combine(filePath, _timeStamp);
        }

        private string GetFilePath() => Directory.GetCurrentDirectory();
    }
}