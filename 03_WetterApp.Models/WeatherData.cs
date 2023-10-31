using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;

namespace _03_WetterApp.Models
{
    public class WeatherData
    {
        public CurrentWeather CurrentWeather { get; }
        public Forecast CurrentForecast { get; }

        public WeatherData(IProcesseable processWeatherData)
        {
            CurrentWeather = processWeatherData.CurrentWeather;
            CurrentForecast = processWeatherData.Forecast;
        }
    }
}
