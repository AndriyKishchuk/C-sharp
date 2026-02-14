using Projekt_3.Energy;
using Projekt_3.Logs;
using Projekt_3.Modules;
using Projekt_3.Storage;
using System;
using System.Xml.Linq;


namespace Projekt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            using (StationLog stationLog = new StationLog(@"C:\\Users\\andri\\source\\repos\\C#\\Projekt_3\\Projekt_3\\station_log.txt"))
            {
                stationLog.Write("Станція запущена.");
                LifeSupportModule lifeSupport = new LifeSupportModule("Життєзабезпечення", 50);
                ScienceModule science = new ScienceModule("Наука", 70);

                science.ResearchProjects.Add("Дослідження мікрогравітації");
                science.ResearchProjects.Add("Вивчення космічної радіації");
                science.ResearchProjects.Add("Розробка нових матеріалів для космосу");

                lifeSupport.Start();
                stationLog.Write($"{lifeSupport.Name} запущено.");
                science.Start();
                stationLog.Write($"{science.Name} запущено.");

                lifeSupport.PerformDiagnostics();
                stationLog.Write($"{lifeSupport.Name} провів діагностику.");
                science.PerformDiagnostics();
                stationLog.Write($"{science.Name} провів діагностику.");

                stationLog.Write("Перевірка енергосистеми");

                SolarPanel solarPanel = new SolarPanel { SunIntensity = 0.85 };
                NuclearReactor reactor = new NuclearReactor { StabilityLevel = 0.95 };

                stationLog.Write($"{solarPanel.EnergyType}: {solarPanel.GetEnergyOutput()} кВт");
                stationLog.Write($"{reactor.EnergyType}: {reactor.GetEnergyOutput()} кВт");

                stationLog.Write("Керування сховищем");

                StorageUnit<Cargo> cargoStorage = new StorageUnit<Cargo>();

                cargoStorage.AddItem(new Cargo { Name = "Кисень", Weight = 5.0 });
                cargoStorage.AddItem(new Cargo { Name = "Вода",  Weight = 15.0 });
                cargoStorage.AddItem(new Cargo { Name = "Продукти", Weight = 8.5 });

                stationLog.Write($"Додано {cargoStorage._items.Count} предметів у сховище.");

                cargoStorage.GetItem(0);
                cargoStorage.GetItem(1);
                cargoStorage.GetItem(2);

                stationLog.Write("Симуляція завершена.");
            }
        }
    }
}