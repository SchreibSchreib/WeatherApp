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
            try
            {
                Run startUp = new Run();
                InitializeComponent();
                DataContext = new ViewModelBackground(new BackgroundImagePath(startUp.WeatherData));
                MessageBox.Show(new BackgroundImagePath(startUp.WeatherData).Get);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }

        private void Location_Initialized(object sender, EventArgs e)
        {
        }
    }
}
