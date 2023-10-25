using _03_WetterApp.Models.Abstraction.Interfaces;

namespace _03_WetterApp.Models
{
    public class Location : ILocateable
    {
        public City UserCity { get; set; }
        public string UserCountry { get; set; }
        public string UserRegion { get; set; }

        public Location()
        {
            
        }

        public string GetLocation(UserIp ipAdress)
        {
            throw new NotImplementedException();
        }
    }
}