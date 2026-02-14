using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    abstract class StationModule
    {
        private int _energyConsumption;
        public string Name { get; init; }
        public bool IsRunning { get; private set; }

        public StationModule(string name, int energyConsumption)
        {
            Name = name;
            _energyConsumption = energyConsumption;
        }

       public abstract void PerformDiagnostics();
       
       public virtual void Start()
       {
            IsRunning = true;
            Console.WriteLine($"{Name} запущено.");
       }
    }
}
