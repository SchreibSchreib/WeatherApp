using _03_WetterApp.Models;
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
            UserIp userIp = new UserIp();

            Debug.WriteLine(userIp.IpV4Adress);
            Debug.WriteLine(userIp.IpV6Adress);
        }
    }
}
