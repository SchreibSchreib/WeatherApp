using _02_WetterApp.Data.Handling;
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

        private void Location_Initialized(object sender, EventArgs e)
        {
            Locator testLocator = new Locator(new UserIp());
            User testUser = new User(testLocator);
            FileInformation fileInformation = new FileInformation();
            Load testLoad = new Load(testUser);
            Save testSave = new Save(testUser);
        }
    }
}
