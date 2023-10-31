using _03_WetterApp.Models;
using _03_WetterApp.Models.StaticClasses;
using IPinfo;
using IPinfo.Models;
using System;
using System.Diagnostics;
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

        private async void Location_Initialized(object sender, EventArgs e)
        {
            Locator testLocator = new Locator(new UserIp());

            User testUser = new User(testLocator);
            TimeStamp.SetTimeStamp();
            string testTime = TimeStamp.GetTimeStamp();
        }
    }
}
