using Microsoft.Extensions.Configuration;
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
        public LocationData CurrentLocation { get; set; }
        public IConfiguration Configuration { get; }

        public User(IConfiguration config)
        {
            Configuration = config;
            UserIp currentIp = new UserIp();
            Locator currentLocation = new Locator(currentIp, Configuration);
            CurrentLocation = new LocationData(currentLocation);
        }
    }
}
