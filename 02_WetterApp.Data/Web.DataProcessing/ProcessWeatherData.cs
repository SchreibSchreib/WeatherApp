﻿using _02_WetterApp.Data.APIRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class ProcessWeatherData
    {
        public ProcessWeatherData(WeatherApiData currentWeather)
        {
            
        }
    }

    public class Current
    {
        public long last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public int is_day { get; set; }
        public double wind_mph { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public double pressure_mb { get; set; }
        public double pressure_in { get; set; }
        public double precip_mm { get; set; }
        public double precip_in { get; set; }
        public int humidity { get; set; }
        public int cloud { get; set; }
        public double feelslike_c { get; set; }
        public double feelslike_f { get; set; }
        public double vis_km { get; set; }
        public double vis_miles { get; set; }
        public double uv { get; set; }
        public double gust_mph { get; set; }
        public double gust_kph { get; set; }
    }

    public class ForeCast
    {

    }
}