using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 elements: ");
        LinkedList<string> list = new LinkedList<string>();
        for (int i = 0; i < 3; i++)
        {
            string? element = Console.ReadLine();
            list.AddLast("Element " + element);
        }
        Console.WriteLine("You want to add new element in average list");
        string? answer = Console.ReadLine();
        if (answer == "Yes" || answer == "yes")
        {
            Console.WriteLine("Enter new element");
            string? newElement = Console.ReadLine();
            LinkedListNode<string>? elements = list.First?.Next;
            if (elements != null)
            {
                list.AddBefore(elements, "Element " + newElement);
            }
        }
        foreach (string element in list)
        {
            Console.WriteLine(element);
        }
    }
}