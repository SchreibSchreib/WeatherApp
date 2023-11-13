using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Abstraction.Interfaces
{
    public interface IInformationable 
    {
        string Current { get; }
        string Forecast { get; }
    }
}
