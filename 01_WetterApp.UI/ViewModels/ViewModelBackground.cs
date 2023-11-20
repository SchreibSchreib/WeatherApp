using _01_WetterApp.UI.Ressources.Backgrounds;
using _01_WetterApp.UI.Ressources.Icons;
using System;
using System.ComponentModel;

namespace _01_WetterApp.UI.ViewModels
{
    class ViewModelBackground : INotifyPropertyChanged
    {
        private string _backgroundImagePath;
        private string _hourIconPath;
        private string _minuteIconPath;
        private string _secondIconPath;

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

        public string HourIconPath
        {
            get { return _hourIconPath; }
            set
            {
                if (_hourIconPath != value)
                {
                    _hourIconPath = value;
                    OnPropertyChanged(nameof(IconPath));
                }
            }
        }

        public string MinuteIconPath
        {
            get { return _minuteIconPath; }
            set
            {
                if (_hourIconPath != value)
                {
                    _hourIconPath = value;
                    OnPropertyChanged(nameof(IconPath));
                }
            }
        }

        public string SecondIconPath
        {
            get { return _secondIconPath; }
            set
            {
                if (_hourIconPath != value)
                {
                    _hourIconPath = value;
                    OnPropertyChanged(nameof(IconPath));
                }
            }
        }

        public ViewModelBackground(BackgroundImagePath pathOfImage,IconPath iconPath)
        {
            _backgroundImagePath = pathOfImage.Get;
            _hourIconPath = iconPath.Get[0];
            _minuteIconPath = iconPath.Get[1];
            _secondIconPath = iconPath.Get[2];
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
