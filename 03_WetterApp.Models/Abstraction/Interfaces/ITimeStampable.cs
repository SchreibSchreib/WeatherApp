﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WetterApp.Models.Abstraction.Interfaces
{
    public interface ITimeStampable : IInformationable
    {
        string TimeStamp { get; }
    }
}
