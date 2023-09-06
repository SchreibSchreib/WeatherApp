using _02_WetterApp.Data.Web.DataProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.ClassesUsedFromData
{
    public class CountryCapital
    {
        public CountryCapital(ProcessLocationData currentLocation)
        {
            Get = currentLocation.CountryCapital;
        }
        public string Get { get; private set; }
    }
}
