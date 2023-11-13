using _01_WetterApp.UI.Ressources.Backgrounds;
using System;
using System.ComponentModel;

namespace _01_WetterApp.UI.ViewModels
{
    class ViewModelBackground : INotifyPropertyChanged
    {
        private string _backgroundImagePath;

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

        public ViewModelBackground(BackgroundImagePath pathOfImage)
        {
            _backgroundImagePath = pathOfImage.Get;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
