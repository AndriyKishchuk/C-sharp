using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class ScienceModule : StationModule
    {
        public List<string> ResearchProjects { get; private set; }

        public ScienceModule(string name, int energyConsumption) : base(name, energyConsumption)
        {
            ResearchProjects = new List<string>();
        }

        public override void PerformDiagnostics()
        {
            Console.WriteLine($"Додано поле <ResearchProjects> i його кількість: {ResearchProjects.Count}");
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} починає наукові дослідження.");
        }
    }
}
