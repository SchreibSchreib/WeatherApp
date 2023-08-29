using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using _04_WetterApp.Models.UI.ModelsContainer;

namespace _01_WetterApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            _currentTown = new HomeTownInformation();
            InitializeComponent();
        }

        private HomeTownInformation _currentTown;

        private void Location_Initialized(object sender, EventArgs e)
        {
            var thisTextbox = sender as TextBox;
            if (thisTextbox == null)
            {
                return;
            }
            thisTextbox.Text = _currentTown.NameOfTown;
        }
    }
}
