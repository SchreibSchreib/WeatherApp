using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.APIConnections
{
    internal class WeatherApiKey
    {
        public WeatherApiKey()
        {
            Get = GetKey();
        }

        public string Get { get; private set; }

        private string GetKey()
        {
            IConfiguration secretApi = new ConfigurationBuilder().AddUserSecrets<WeatherApiKey>().Build();

            if (secretApi == null || secretApi["ApiKey"] == null)
            {
                throw new InvalidOperationException("API-Key not found in user secrets.");
            }

            return secretApi["ApiKeyWeather"]!;
        }
    }
}
