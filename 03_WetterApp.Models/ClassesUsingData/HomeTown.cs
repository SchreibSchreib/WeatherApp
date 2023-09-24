﻿using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing;

namespace _03_WetterApp.Models.ClassesUsingData
{
    public class HomeTown
    {
        public HomeTown(ProcessLocationData currentLocation)
        {
            CountryName = currentLocation.Country;
            GetName = currentLocation.City;
            GetLatitude = currentLocation.Latitude;
            GetLongitude = currentLocation.Longitude;
        }

        public string CountryName { get; private set; }
        public string GetName { get; private set; }
        public string GetLatitude { get; private set; }
        public string GetLongitude { get; private set;}

    }
}