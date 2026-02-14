using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class SolarPanel : IEnergySource
    {
        public string EnergyType => "Сонячна енергія";
        public double SunIntensity { get; set; }
        public double GetEnergyOutput()
        {
            return 100.0 * SunIntensity;
        }
    }

}
