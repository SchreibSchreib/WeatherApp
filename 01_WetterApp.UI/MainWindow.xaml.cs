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

            Locator testLocator = new Locator(new UserIp(), testConfig);
            User testUser = new User(testLocator);
        }
    }
}
