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
       Task<ForecastWeatherInformation>? ForecastFromHttp(string url);
       Task<CurrentWeatherInformation>? CurrentFromHttp(string url);
       ForecastWeatherInformation? ForecastFromJson(string filePath);
       CurrentWeatherInformation? CurrentFromJson(string filePath);
    }
}
