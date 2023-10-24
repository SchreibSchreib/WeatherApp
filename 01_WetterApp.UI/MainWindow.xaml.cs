using _03_WetterApp.Models;
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
            User currenntUser = new User();
        }
    }
}
