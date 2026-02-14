using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal interface IEnergySource
    {
        public string EnergyType { get; }
        double GetEnergyOutput();
    }
}
