using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class LifeSupportModule : StationModule
    {
        public double OxygenLevel { get; private set; }

        public LifeSupportModule(string name, int energyConsumption) : base(name, energyConsumption)
        {
            OxygenLevel = 98.5;
        }

        public override void PerformDiagnostics()
        {
            Console.WriteLine($"Рівень кисню в повітрі {OxygenLevel}");
        }
    }
}
