using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Abstraction.AbstractClasses
{
    public abstract class Location
    {
        public string Name { get; }

        public Location(string name)
        {
            Name = name;
        }
    }
}
