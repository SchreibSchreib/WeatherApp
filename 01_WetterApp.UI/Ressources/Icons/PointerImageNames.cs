using _03_WetterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WetterApp.UI.Ressources.Icons
{
    internal class PointerImageNames
    {
        public string[] Get { get; }

        private WeatherData _weatherData;

        public PointerImageNames(WeatherData weatherData)
        {
            _weatherData = weatherData;
            Get = PickIcon();
        }

        private string[] PickIcon()
        {
            string[] nameOfIcon = Evaluate();

            return nameOfIcon;
        }

        private string[] Evaluate()
        {
            string[] pointerIcon = new string[3];

            pointerIcon[0] = IsDay() ? "Sun100x100" : "Moon100x100";
            pointerIcon[1] = IsPrecipitationHigh() ? "Rain100x100" : "NoRain100x100";
            pointerIcon[2] = IsCloudy() ? "Cloud100x100" : "NoCloud100x100";

            return pointerIcon;
        }

        private bool IsDay() => Convert.ToBoolean(_weatherData.CurrentWeather.Current.IsDay);

        private bool IsCloudy() => _weatherData.CurrentWeather.Current.CloudCover > 60;

        private bool IsPrecipitationHigh() => _weatherData.CurrentWeather.Current.PrecipitationMm > 1.5;

        private bool IsFoggy() => _weatherData.CurrentWeather.Current.VisibilityKm < 1;
    }
}
