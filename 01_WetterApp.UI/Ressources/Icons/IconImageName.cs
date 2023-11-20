using _03_WetterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WetterApp.UI.Ressources.Icons
{
    internal class IconImageName
    {
        public string Get { get; }

        private WeatherData _weatherData;

        public IconImageName(WeatherData weatherData)
        {
            _weatherData = weatherData;
            Get = PickIcon() + ".png";
        }

        private string PickIcon()
        {
            string nameOfIcon = Evaluate();

            return nameOfIcon;
        }

        private string Evaluate()
        {
            string fileName;

            if (IsPrecipitationHigh()) return "Rain100x100";
            if (IsCloudy()) return "Cloud100x100";
            if (IsDay()) return "Sun100x100";
            return "Moon100x100";
        }

        private bool IsDay() => Convert.ToBoolean(_weatherData.CurrentWeather.Current.IsDay);

        private bool IsCloudy() => _weatherData.CurrentWeather.Current.CloudCover > 60;

        private bool IsPrecipitationHigh() => _weatherData.CurrentWeather.Current.PrecipitationMm > 1.5;

        private bool IsFoggy() => _weatherData.CurrentWeather.Current.VisibilityKm < 1;
    }
}
