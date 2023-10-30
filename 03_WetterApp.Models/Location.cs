using _03_WetterApp.Models.Abstraction.Interfaces;

namespace _03_WetterApp.Models
{
    public class Location
    {
        public Country UserCountry { get; }
        public Region UserRegion { get; }
        public City UserCity { get; }
        private ILocateable _locateable;

        public Location(ILocateable locateable)
        {
            _locateable = locateable;
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
            return _locateable.LocateCityAsync();
        }
    }
}