using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class Cargo
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Cargo()
        {
           // Name = this.Name;
           // Weight = this.Weight;
        }

        public override string ToString()
        {
            return $"{Name} (вага: {Weight} кг)";
        }
    }
}
