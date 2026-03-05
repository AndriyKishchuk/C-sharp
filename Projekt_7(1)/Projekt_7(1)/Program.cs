using System;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> products = new Queue<string>();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter product name:");
            string? productName = Console.ReadLine();
            products.Enqueue(productName);
        }
        Console.WriteLine("Product:");
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
        Console.ReadKey();
        while (products.Count > 0)
        {
            string product = products.Dequeue();
            Console.WriteLine($"Narrowing lorry with product: {product}");
        }
        if (products.Count == 0)
        {
            Console.WriteLine("Lorry is empty.");
        }
        Console.ReadKey();
        Stack<string> productStack = new Stack<string>();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter products to narrow lorry:");
            productStack.Push(Console.ReadLine());
        }
        while (productStack.Count > 0)
        {
            string product = productStack.Pop();
            Console.WriteLine($"Narrowing lorry with product: {product}");
        }
        if (productStack.Count == 0)
        {
            Console.WriteLine("Lorry is empty.");
        }


    }
}