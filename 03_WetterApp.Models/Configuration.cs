using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models
{
    public class Configuration
    {
        public IConfiguration? Config;

        public Configuration()
        {
            Config = GetConfiguration();
        }

        private IConfiguration? GetConfiguration()
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Config.json")
            .Build();

            return config;
            
        }
    }
}
