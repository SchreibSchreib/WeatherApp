using _03_WetterApp.Models.ClassesUsingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _03_WetterApp.Models;
using _03_WetterApp.Models.ClassesUsedByUI;
using _02_WetterApp.Data.APIRequests;

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
            WeatherApiData test = new WeatherApiData(new _02_WetterApp.Data.Web.DataProcessing.ProcessLocationData());
            User currentUser = new User();

            Location.Text = currentUser.ActualTime.ToString();
        }
    }
}
