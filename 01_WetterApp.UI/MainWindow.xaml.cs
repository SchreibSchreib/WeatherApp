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
                UpdateClock();
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
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            return timer;
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            double[] angles = GetPointerAngles();
            double radius = 305;
            TranslateTransform[] translateTransform = GetTranslateTransform(angles, radius);
            hourIcon.RenderTransform = translateTransform[0];
            minuteIcon.RenderTransform = translateTransform[1];
            secondIcon.RenderTransform = translateTransform[2];
        }

        private double[] GetPointerAngles()
        {
            DateTime currentTime = DateTime.Now;
            double[] angles = new double[3];
            angles[0] = (currentTime.Hour % 12 + currentTime.Minute / 60.0) * (2 * Math.PI / 12); //Hours
            angles[1] = (currentTime.Minute % 60 + currentTime.Second / 60.0) * (2 * Math.PI / 60); //Minutes
            angles[2] = (currentTime.Second % 60) * (2 * Math.PI / 60); //Seconds

            return angles;
        }

        private TranslateTransform[] GetTranslateTransform(double[] angles, double radius)
        {
            TranslateTransform[] transforms = new TranslateTransform[3];
            transforms[0] = new TranslateTransform(GetCenterX(radius, angles[0]), GetCenterY(radius, angles[0]));
            transforms[1] = new TranslateTransform(GetCenterX(radius, angles[1]), GetCenterY(radius, angles[1]));
            transforms[2] = new TranslateTransform(GetCenterX(radius, angles[2]), GetCenterY(radius, angles[2]));

            return transforms;
        }

        private double GetCenterX(double radius, double angle) => radius * Math.Sin(angle);

        private double GetCenterY(double radius, double angle) => -radius * Math.Cos(angle);

    }
}
