using _01_WetterApp.UI.Ressources.Backgrounds;
using _03_WetterApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WetterApp.UI.Ressources.Icons
{
    internal class IconPath
    {
        public string Get { get; }
        private string _currentDirectory;

        public IconPath(WeatherData weatherData)
        {
            IconImageName imageName = new IconImageName(weatherData);
            _currentDirectory = GetParentDirectory();
            Get = Path.Combine(GetFullPath(), imageName.Get);
        }

        private string GetParentDirectory() => Directory.GetCurrentDirectory();

        private string GetFullPath() => Path.Combine(_currentDirectory, "Ressources", "Icons");
    }
}
