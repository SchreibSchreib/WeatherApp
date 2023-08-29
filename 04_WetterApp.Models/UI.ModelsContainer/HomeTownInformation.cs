using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WetterApp.Models.UI.ModelsContainer
{
    public class HomeTownInformation
    {
        public HomeTownInformation()
        {
            TimeOfTown = DateTime.Now;
            LocationOfTown = new Location(new WebClient().DownloadString("https://api.ipify.org"));
            NameOfTown = LocationOfTown.Name;
        }

        public string NameOfTown { get; }
        public DateTime TimeOfTown { get; }
        public Location LocationOfTown { get; }
    }
}
