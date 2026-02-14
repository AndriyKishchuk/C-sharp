using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{
    public record CargoManifest
    {
       public string Name { get; init; }
       public double Weight { get; init; }
       public string Category { get; init; }
    }
}
