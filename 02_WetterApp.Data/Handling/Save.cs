using _03_WetterApp.Models;
using _03_WetterApp.Models.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Handling
{
    public class Save : IWriteable
    {
        private User _currentUser;

        public Save(User currentUser)
        {
            _currentUser = currentUser;
        }

        public void WriteCurrentToJson(string jsonContent, string filePath)
        {
            throw new NotImplementedException();
        }

        public void WriteForecastToJson(string jsonContent, string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
