using _03_WetterApp.Models;
using System;
using System.Data;
using System.Drawing;
using System.Text;

namespace _01_WetterApp.UI.Ressources.Backgrounds
{
    public class BackgroundImageName
    {
        public string Get { get; }

        private WeatherData _weatherData;

        public BackgroundImageName(WeatherData weatherData)
        {
            _weatherData = weatherData;
            Get = PickImage() + ".png";
        }

        private string PickImage()
        {
            string nameOfBackGroundImage = Evaluate();

            return nameOfBackGroundImage;
        }

        private string Evaluate()
        {
            StringBuilder fileName = new StringBuilder();

            fileName.Append(IsDay() ? "Day" : "Night");
            fileName.Append(GetSeason());
            if (IsFoggy())
            {
                fileName.Append("Foggy");
                return fileName.ToString();
            }
            fileName.Append(IsCloudy() ? "Cloudy" : "NotCloudy");
            fileName.Append(IsPrecipitationHigh() ? "HighPrecipitation": "LowPrecipitation");

            return fileName.ToString();
        }

        private bool IsDay() => Convert.ToBoolean(_weatherData.CurrentWeather.Current.IsDay);

        private string GetSeason()
        {
            int currentMonth = DateTime.Now.Month;

            switch (currentMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";

                case 3:
                case 4:
                case 5:
                    return "Spring";

                case 6:
                case 7:
                case 8:
                    return "Summer";

                case 9:
                case 10:
                case 11:
                    return "Autumn";

                default:
                    return "Summer";
            }
        }

        private bool IsCloudy() => _weatherData.CurrentWeather.Current.CloudCover > 60;

        private bool IsPrecipitationHigh() => _weatherData.CurrentWeather.Current.PrecipitationMm > 4;

        private bool IsFoggy() => _weatherData.CurrentWeather.Current.VisibilityKm < 1;
    }
}