using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3.Storage
{
    internal class Cargo
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Cargo() { }
        
        public override string ToString()
        {
            return $"{Name} (вага: {Weight} кг)";
        }
    }
}
