using System;
using System.Collections.Generic;
using System.Text;


namespace Projekt_2
{
    internal class SpaceShip
    {
        private double _fuel;
        public string Name { get; }
        public Coordinates CurrentPosition { get; set; }
        public double MaxCapacity { get; }

        private List<CargoManifest> cargoManifests;

        public IReadOnlyList<CargoManifest> CargoManifests => cargoManifests.AsReadOnly();

        public SpaceShip(string name, double maxCapacity)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            cargoManifests = new List<CargoManifest>();
            _fuel = 1000;
            CurrentPosition = new Coordinates(0, 0, 0);
        }

        public SpaceShip(string name) : this(name, 1000)
        { }

        public bool AddCargo(CargoManifest item)
        {
            double currentWeight = cargoManifests.Sum(c => c.Weight);
            if (currentWeight + item.Weight <= MaxCapacity)
            {
                cargoManifests.Add(item);
                return true;
            }

            else
            {
                Console.WriteLine($"Cannot add {item.Name}. Exceeds max capacity.");
                return false;
            }
        }
        public bool FlyTo(Coordinates newPosition)
        {
            double distance = CurrentPosition.GetDistance(newPosition);
            double fuelNeeded = distance / 10;

            if (_fuel >= fuelNeeded)
            {
                _fuel -= fuelNeeded;
                CurrentPosition = newPosition;
                return true;
            }

            return false;

        }

        public override string ToString()
        {
            return $"SpaceShip: {Name}, Position: ({CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z})";
        }

    }
}
