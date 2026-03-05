using System;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter product ID:");
            if (!int.TryParse(Console.ReadLine(), out int id) || id<=0)
            {
                Console.WriteLine("Invalid input for product ID. Please enter a valid integer.");
                break;
            }
            Console.WriteLine("Enter product name:");
            string? name = Console.ReadLine();
            products.Add(id, name);
        }
        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.Key}, Product Name: {product.Value}");
        }
        Console.ReadKey();
        Console.WriteLine("List of VIP-clients:");
        SortedList<int, string> vipClients = new SortedList<int, string>();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter client ID:");
            if (!int.TryParse(Console.ReadLine(), out int clientId) || clientId<=0)
            {
                Console.WriteLine("Invalid input for client ID. Please enter a valid integer.");
                break;
            }
            Console.WriteLine("Enter client name:");
            string? name = Console.ReadLine();
            vipClients.Add(clientId, name);
        }
        foreach (var client in vipClients)
        {
            Console.WriteLine($"Client ID: {client.Key}, Client Name: {client.Value}");
        }
    }
}   