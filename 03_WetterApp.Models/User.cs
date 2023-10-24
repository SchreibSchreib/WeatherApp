using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public Location CurrentLocation { get; set; }
        public WeatherInformation CurrentWeather { get; set; }
    }
}
