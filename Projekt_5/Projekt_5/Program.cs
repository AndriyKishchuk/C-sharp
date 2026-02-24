using Projekt_5;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Warehouse warehouse = new Warehouse();
        warehouse.OnItemChanged += (index, value) => Console.WriteLine($"Лог: У комірку #{index} додано товар: {value}");

        List<string> strings = new List<string> {"Товар 1", "Товар 2", "", "Товар 3", "Товар 4", "Товар 5"};
        Predicate<string> isNotEmpty = item => !string.IsNullOrEmpty(item);
        Func<string, string> toUpper = item => item.ToUpper();

        for (int i = 0; i < strings.Count; i++)
        {
            if (isNotEmpty(strings[i]))
            {
                string upperString = toUpper(strings[i]);
                warehouse[i] = upperString;
            }
        }
        Console.WriteLine("Вміст складу: ");
        for(int i = 0; i < strings.Count; i++)
        {
            Console.WriteLine(warehouse[i]);
        }

    }
}