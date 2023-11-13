using _03_WetterApp.Models.Abstraction.Interfaces;
using _03_WetterApp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using _02_WetterApp.Data.Handling;
using _02_WetterApp.Data;

namespace _01_WetterApp.UI.Classes
{
    public class Run
    {
        public WeatherData WeatherData { get; }

        private IConfiguration _config;
        private ITimeStampable _fileData;
        private IInformationable _apiData;
        private IReadeable _loadData;
        private IWriteable _saveData;

        public Run()
        {
            _config = GetConfig();
            _fileData = GetFileInformation();
            _apiData = GetApiData();
            _loadData = GetLoadData();
            _saveData = GetSaveData();
            WeatherData = GetWeatherData();
        }

        private IConfiguration GetConfig()
        {
            IConfiguration? config = new Configuration().Config;

            if (config is null)
            {
                MessageBox.Show("Couldnt load Configuration file.");
                throw new FileNotFoundException();
            }

            return config;
        }

        private ITimeStampable GetFileInformation() => new FileInformation();

        private IInformationable GetApiData() => new ApiInformation(new User(_config));

        private IReadeable GetLoadData() => new Load();

        private IWriteable GetSaveData() => new Save();

        private WeatherData GetWeatherData()
        {
            WeatherDataProcessor processWeatherData = new WeatherDataProcessor(
                _fileData,
                _apiData,
                _loadData,
                _saveData);

            return new WeatherData(processWeatherData);
        }
    }
}
