using _03_WetterApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _01_WetterApp.UI.Ressources.Backgrounds
{
    class BackgroundImagePath
    {
        public string Get { get; }
        private string _currentDirectory;

        public BackgroundImagePath(WeatherData weatherData)
        {
            BackgroundImageName imageName = new BackgroundImageName(weatherData);
            _currentDirectory = GetParentDirectory();
            Get = Path.Combine(GetFullPath(), imageName.Get);
        }

        private string GetParentDirectory() => Directory.GetCurrentDirectory();

        private string GetFullPath() => Path.Combine(_currentDirectory, "Ressources", "Backgrounds");
    }
}
