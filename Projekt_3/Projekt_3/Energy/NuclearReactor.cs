using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class NuclearReactor : IEnergySource
    {
        public string EnergyType => "Ядерна енергія";
        public double StabilityLevel { get; set; } = 1.0;
        public double GetEnergyOutput()
        {
            return 1000.0 * StabilityLevel;
        }
    }
}
