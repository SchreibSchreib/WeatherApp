using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using Microsoft.Extensions.Configuration;
using _02_WetterApp.Data.APIConnections;
using System.Net;

namespace _02_WetterApp.Data.APIRequests
{
    public class WeatherApiData
    {
        public WeatherApiData(ProcessLocationData currentLocation)
        {
            _latitude = currentLocation.Latitude;
            _longitude = currentLocation.Longitude;
            _apiKey = new WeatherApiKey().Get;
            CurrentContent = GetCurrentContent();
            ForeCastContent = GetForeCastContent();
        }

        private string _latitude;
        private string _longitude;
        private string _apiKey;

        public string CurrentContent { get; private set; }
        public string ForeCastContent { get; private set; }

        private string GetCurrentContent()
        {
            try
            {
                string apiUrl = $"http://api.weatherapi.com/v1/current.json?key={_apiKey}&q=Magdeburg&aqi=no";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                string dataAsText = reader.ReadToEnd();
                                return dataAsText;
                            }
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Fehler beim Abrufen der Daten von der API");
                        return "Hier DefaultWetter";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "Hier DefaultWetter";
            }
        }

        private string GetForeCastContent()
        {
            try
            {
                string apiUrl = $"http://api.weatherapi.com/v1/forecast.json?key={_apiKey}&q=Magdeburg&days=3&aqi=no&alerts=no";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                string dataAsText = reader.ReadToEnd();
                                return dataAsText;
                            }
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Fehler beim Abrufen der Daten von der API");
                        return "Hier DefaultWetter";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "Hier DefaultWetter";
            }
        }
    }
}

