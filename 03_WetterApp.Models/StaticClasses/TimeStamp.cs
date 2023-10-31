using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.StaticClasses
{
    public static class TimeStamp
    {
        private static DateTime _currentTimeStamp;

        public static string GetTimeStamp() => string.Join(':', _currentTimeStamp.Hour, _currentTimeStamp.Minute);
        

        public static void SetTimeStamp()
        {
            _currentTimeStamp = DateTime.Now.ToLocalTime();
        }
    }
}
