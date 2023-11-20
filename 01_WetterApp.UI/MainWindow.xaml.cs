using _01_WetterApp.UI.Classes;
using _01_WetterApp.UI.Ressources.Backgrounds;
using _01_WetterApp.UI.Ressources.Icons;
using _01_WetterApp.UI.ViewModels;
using _02_WetterApp.Data;
using _02_WetterApp.Data.Handling;
using _03_WetterApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace _01_WetterApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Run startUp = new Run();
                timer = GetTimer();
                DataContext = new ViewModelBackground(
                    new BackgroundImagePath(startUp.WeatherData),
                    new IconPath(startUp.WeatherData));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }

        private DispatcherTimer GetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += OnTimerTick;
            timer.Interval = new TimeSpan(0, 2, 0);
            timer.Start();
            return timer;
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            DateTime now = DateTime.Now;
            double angle = (now.Millisecond * 6) * (Math.PI / 180); // 6 Grad pro Sekunde
            double radius = 305; // Halbe Breite/Höhe des Hintergrundkreises
            TranslateTransform translateTransform = new TranslateTransform(GetCenterX(radius, angle), GetCenterY(radius, angle));
            timeEllipse.RenderTransform = translateTransform;
        }

        private double GetCenterX(double radius, double angle) => radius * Math.Sin(angle);

        private double GetCenterY(double radius, double angle) => -radius * Math.Cos(angle);

    }
}
