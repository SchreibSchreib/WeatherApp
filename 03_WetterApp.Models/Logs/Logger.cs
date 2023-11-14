using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Logs
{
    public static class Logger
    {
        private static string _logFilePath = Directory.GetCurrentDirectory();

        public static void LogException(string nameOfFile, Exception ex)
        {
            string fullPath = _logFilePath + nameOfFile + ".txt";

            if (File.Exists(fullPath))
            {
                File.WriteAllText(fullPath, ex.Message);
            }
            else
            {
                File.Create(fullPath);
            }
        }
    }
}
