using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.APIConnections
{
    internal class WeatherStackAPIKey
    {
        public WeatherStackAPIKey()
        {
            Get = GetKey();
        }

        public string Get { get; private set; }

        private string GetKey()
        {
            IConfiguration secretApi = new ConfigurationBuilder().AddUserSecrets<WeatherStackAPIKey>().Build();

            if (secretApi == null || secretApi["ApiKey"] == null)
            {
                throw new InvalidOperationException("API-Key not found in user secrets.");
            }

            return secretApi["ApiKeyWeather"]!;
        }
    }
}
