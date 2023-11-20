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
        public string[] Get { get; }
        private string _currentDirectory;

        public IconPath(WeatherData weatherData)
        {
            PointerImageNames imageName = new PointerImageNames(weatherData);
            _currentDirectory = GetParentDirectory();
            Get = GetFullPath(imageName);
        }

        private string GetParentDirectory() => Directory.GetCurrentDirectory();

        private string[] GetFullPath(PointerImageNames currentPointer)
        {
            string[] pointerIcons =
            {
                 Path.Combine(_currentDirectory, "Ressources", "Icons",currentPointer.Get[0])  + ".png",
                 Path.Combine(_currentDirectory, "Ressources", "Icons",currentPointer.Get[1])  + ".png",
                 Path.Combine(_currentDirectory, "Ressources", "Icons",currentPointer.Get[2])  + ".png"
            };
            return pointerIcons;
        }
    }
}

