using _01_WetterApp.UI.Ressources.Backgrounds;
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
            InitializeComponent();
        }

        private void Location_Initialized(object sender, EventArgs e)
        {
            IConfiguration? testConfig = new Configuration().Config;

            if (testConfig is null)
            {
                MessageBox.Show("Couldnt load Configuration file.");
                throw new NullReferenceException();
            }
            User testUser = new User(new Locator(new UserIp(), testConfig));
            FileInformation testInfo = new FileInformation();
            ApiInformation apiInformation = new ApiInformation(testUser, testConfig);
            Load load = new Load();
            Save save = new Save();
            WeatherDataProcessor weatherDataProcessor = new WeatherDataProcessor(testInfo, apiInformation,load,save);

            WeatherData weatherData = new WeatherData(weatherDataProcessor);

            BackgroundImagePath backgroundImagePath = new BackgroundImagePath(weatherData);
        }
    }
}
