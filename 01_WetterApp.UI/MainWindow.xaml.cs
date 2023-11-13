using _01_WetterApp.UI.Classes;
using _01_WetterApp.UI.Ressources.Backgrounds;
using _01_WetterApp.UI.ViewModels;
using _02_WetterApp.Data;
using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows;

namespace _01_WetterApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Run startUp = new Run();
            InitializeComponent();
            DataContext = new ViewModelBackground(new BackgroundImagePath(startUp.WeatherData));
        }

        private void Location_Initialized(object sender, EventArgs e)
        {
        }
    }
}
