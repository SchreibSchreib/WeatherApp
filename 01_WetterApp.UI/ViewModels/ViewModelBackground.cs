using _01_WetterApp.UI.Ressources.Backgrounds;
using _01_WetterApp.UI.Ressources.Icons;
using System;
using System.ComponentModel;

namespace _01_WetterApp.UI.ViewModels
{
    class ViewModelBackground : INotifyPropertyChanged
    {
        private string _backgroundImagePath;
        private string _iconPath;

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

        public string IconPath
        {
            get { return _iconPath; }
            set
            {
                if (_iconPath != value)
                {
                    _iconPath = value;
                    OnPropertyChanged(nameof(IconPath));
                }
            }
        }

        public ViewModelBackground(BackgroundImagePath pathOfImage,IconPath iconPath)
        {
            _backgroundImagePath = pathOfImage.Get;
            _iconPath = iconPath.Get;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
