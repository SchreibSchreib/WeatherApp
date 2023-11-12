using System.ComponentModel;

namespace _01_WetterApp.UI.ViewModels
{
    class ViewModelBackground : INotifyPropertyChanged
    {
        private string _backgroundImagePath;

        public ViewModelBackground()
        {
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
