using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WetterApp.UI.Ressources.Backgrounds
{
    class BackgroundImagePath
    {
        public string Get { get; }

        public BackgroundImagePath(BackgroundImageName imageName)
        {
            Get = GetFullPath() + imageName.Get;
        }

        private string GetFullPath() => Directory.GetCurrentDirectory();
    }
}
