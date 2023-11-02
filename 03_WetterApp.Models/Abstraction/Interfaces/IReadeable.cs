using _03_WetterApp.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Abstraction.Interfaces
{
    public interface IReadeable
    {
       Task<Forecast>? ForecastFromHttp(string url);
       Task<CurrentWeather>? CurrentFromHttp(string url);
       Forecast? ForecastFromJson(string filePath);
       CurrentWeather? CurrentFromJson(string filePath);
    }
}
