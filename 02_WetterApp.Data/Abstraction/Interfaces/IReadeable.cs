using _03_WetterApp.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Abstraction.Interfaces
{
    interface IReadeable
    {
        Forecast ForecastFromJson(string filePath);
        CurrentWeather CurrentFromJson(string filePath);
    }
}
