using _01_WetterApp.UI.Ressources.Backgrounds;
using _01_WetterApp.UI.Ressources.Icons;
using System;
using System.ComponentModel;

namespace _01_WetterApp.UI.ViewModels
{
    class ViewModelBackground : INotifyPropertyChanged
    {
        private string _backgroundImagePath;
        private string[] _iconPaths;

        public string BackgroundImagePath
        {
            get { return _backgroundImagePath; }
            set
            {
                if (_backgroundImagePath != value)
                {
                    _backgroundImagePath = value;
                    OnPropertyChanged(nameof(BackgroundImagePath));
                }
            }
        }

        public string[] IconPaths
        {
            get { return _iconPaths; }
            set
            {
                if (!Array.Equals(_iconPaths, value))
                {
                    _iconPaths = value;
                    OnPropertyChanged(nameof(IconPaths));
                }
            }
        }



        public ViewModelBackground(BackgroundImagePath pathOfImage, IconPath iconPath)
        {
            _backgroundImagePath = pathOfImage.Get;
            _iconPaths = iconPath.Get;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
