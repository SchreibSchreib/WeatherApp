using _03_WetterApp.Models.Abstraction.Interfaces;

namespace _03_WetterApp.Models
{
    public class Location
    {
        public Country UserCountry { get; }
        public Region UserRegion { get; }
        public City UserCity { get; }
        private ILocateable _locateable;

        public Location()
        {
            _locateable = new Locator(new UserIp());
            UserCountry = GetCountry();
            UserRegion = GetRegion();
            UserCountry = GetCountry();
        }

        private Country? GetCountry()
        {
            throw new NotImplementedException();
        }

        private Region? GetRegion()
        {
            throw new NotImplementedException();
        }

        private City GetCity()
        {
            throw new NotImplementedException();
        }


    }
}