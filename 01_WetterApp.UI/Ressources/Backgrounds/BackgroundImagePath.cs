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
        private string _parentDirectory;

        public BackgroundImagePath(WeatherData weatherData)
        {
            BackgroundImageName imageName = new BackgroundImageName(weatherData);
            _parentDirectory = GetParentDirectory();
            Get = Path.Combine(GetFullPath(), imageName.Get);
        }

        private string GetParentDirectory()
        {
            string? parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())
                ?.Parent
                ?.Parent
                ?.FullName;

            if (parentDirectory != null)
            {
                return parentDirectory;
            }
            MessageBox.Show("Could not find the Ressources Folder." +
                "Program will shut down.");

            throw new FileNotFoundException();

        }

        private string GetFullPath() => Path.Combine(_parentDirectory, "Ressources", "Backgrounds");
    }
}
