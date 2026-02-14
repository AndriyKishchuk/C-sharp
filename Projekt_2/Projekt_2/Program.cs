using Projekt_2;
class Program
{
    static void Main(string[] args)
    {
        var cargo1 = new CargoManifest { Name = "Food Supplies", Weight = 500, Category = "Perishable" };
        var cargo2 = new CargoManifest { Name = "Electronics", Weight = 300, Category = "Fragile" };
        var cargo3 = cargo1 with { Name = "Applies", Weight = 500, Category = "Perishable" };

        var spaceShip = new SpaceShip("Galaxy Explorer", 2000);
        
        spaceShip.AddCargo(cargo1);
        spaceShip.AddCargo(cargo2);
        spaceShip.AddCargo(cargo3);

        var coordinates = new Coordinates(10, 20, 60);

        spaceShip.FlyTo(coordinates);
        Console.WriteLine($"{spaceShip.ToString()}");
        Console.WriteLine("Cargo on board:");

        foreach(var cargo in spaceShip.CargoManifests)
        {
            Console.WriteLine($"{cargo.Name}");
        }
    }
}