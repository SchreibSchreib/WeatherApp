using _02_WetterApp.Data.APIRequests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class ProcessWeatherData
    {
        public ProcessWeatherData(WeatherApiData weatherData)
        {
            _weatherData = weatherData;
        }

        private WeatherApiData _weatherData;

        public Current GetCurrent() => JsonConvert.DeserializeObject<Current>(_weatherData.CurrentContent);

        public ForeCast GetForecast() => JsonConvert.DeserializeObject<ForeCast>(_weatherData.ForeCastContent);

    }

    public class Current
    {
        public long last_updated_epoch { get; set; }
        public string last_updated { get; set; } = string.Empty;
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public int is_day { get; set; }
        public double wind_mph { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; } = string.Empty;
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
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("date_epoch")]
        public long DateEpoch { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("astro")]
        public Astro Astro { get; set; }

        [JsonProperty("hour")]
        public List<Hour> Hours { get; set; }
    }

    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTempC { get; set; }

        [JsonProperty("maxtemp_f")]
        public double MaxTempF { get; set; }

        [JsonProperty("mintemp_c")]
        public double MinTempC { get; set; }

        [JsonProperty("mintemp_f")]
        public double MinTempF { get; set; }

        [JsonProperty("avgtemp_c")]
        public double AvgTempC { get; set; }

        [JsonProperty("avgtemp_f")]
        public double AvgTempF { get; set; }

        [JsonProperty("maxwind_mph")]
        public double MaxWindMph { get; set; }

        [JsonProperty("maxwind_kph")]
        public double MaxWindKph { get; set; }

        [JsonProperty("totalprecip_mm")]
        public double TotalPrecipMm { get; set; }

        [JsonProperty("totalprecip_in")]
        public double TotalPrecipIn { get; set; }

        [JsonProperty("totalsnow_cm")]
        public double TotalSnowCm { get; set; }

        [JsonProperty("avgvis_km")]
        public double AvgVisKm { get; set; }

        [JsonProperty("avgvis_miles")]
        public double AvgVisMiles { get; set; }

        [JsonProperty("avghumidity")]
        public double AvgHumidity { get; set; }

        [JsonProperty("daily_will_it_rain")]
        public int DailyWillItRain { get; set; }

        [JsonProperty("daily_chance_of_rain")]
        public int DailyChanceOfRain { get; set; }

        [JsonProperty("daily_will_it_snow")]
        public int DailyWillItSnow { get; set; }

        [JsonProperty("daily_chance_of_snow")]
        public int DailyChanceOfSnow { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }

    public class Astro
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }

        [JsonProperty("moonset")]
        public string Moonset { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moon_illumination")]
        public string MoonIllumination { get; set; }

        [JsonProperty("is_moon_up")]
        public int IsMoonUp { get; set; }

        [JsonProperty("is_sun_up")]
        public int IsSunUp { get; set; }
    }

    public class Hour
    {
        [JsonProperty("time_epoch")]
        public long TimeEpoch { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("is_day")]
        public int IsDay { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public double WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeC { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeF { get; set; }

        [JsonProperty("windchill_c")]
        public double WindchillC { get; set; }

        [JsonProperty("windchill_f")]
        public double WindchillF { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatindexC { get; set; }

        [JsonProperty("heatindex_f")]
        public double HeatindexF { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewpointC { get; set; }

        [JsonProperty("dewpoint_f")]
        public double DewpointF { get; set; }

        [JsonProperty("will_it_rain")]
        public int WillItRain { get; set; }

        [JsonProperty("chance_of_rain")]
        public int ChanceOfRain { get; set; }

        [JsonProperty("will_it_snow")]
        public int WillItSnow { get; set; }

        [JsonProperty("chance_of_snow")]
        public int ChanceOfSnow { get; set; }

        [JsonProperty("vis_km")]
        public double VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public double GustKph { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }
}
