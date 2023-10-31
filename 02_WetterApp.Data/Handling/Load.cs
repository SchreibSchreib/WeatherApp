using _03_WetterApp.Models;
using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models.Weather;


namespace _02_WetterApp.Data.Handling
{
    internal class Load : IReadeable
    {
        private User _currentUser;

        public Load(User currentUser)
        {
            _currentUser = currentUser;
        }

        public CurrentWeather CurrentFromJson(string filePath)
        {
            throw new NotImplementedException();
        }

        public Forecast ForecastFromJson(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
