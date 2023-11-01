using _03_WetterApp.Models.Abstraction.Interfaces;
using Microsoft.Extensions.Configuration;

namespace _03_WetterApp.Models
{
    public class LocationData
    {
        public Country UserCountry { get; }
        public Region UserRegion { get; }
        public City UserCity { get; }
        private ILocateable _locateable;
        private string? _apiKey;

        public LocationData(ILocateable locateable, IConfiguration config)
        {

            _locateable = locateable;
            _apiKey = config["ApiKeyIpInfo"];
            UserCountry = GetCountry();
            UserRegion = GetRegion();
            UserCity = GetCity();
        }

        private Country GetCountry()
        {
            return _locateable.LocateCountry();
        }

        private Region GetRegion()
        {
           return _locateable.LocateRegion();
        }

        private City GetCity()
        {
            return _locateable.LocateCity();
        }
    }
}