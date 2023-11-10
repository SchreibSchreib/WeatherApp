using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;

namespace _03_WetterApp.Models
{
    public class WeatherData
    {
        public CurrentWeatherInformation CurrentWeather { get; }
        public ForecastWeatherInformation CurrentForecast { get; }

        public WeatherData(IProcesseable processWeatherData)
        {
            CurrentWeather = processWeatherData.GetCurrentWeather;
            CurrentForecast = processWeatherData.GetForecast;
        }
    }
}
