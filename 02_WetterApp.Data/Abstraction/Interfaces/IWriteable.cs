using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Abstraction.Interfaces
{
    interface IWriteable
    {
        void WriteForecastToJson(string jsonContent, string filePath);
        void WriteCurrentToJson(string jsonContent, string filePath);
    }
}
