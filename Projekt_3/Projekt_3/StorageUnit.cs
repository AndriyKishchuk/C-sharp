using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_3
{
    internal class StorageUnit<T> where T : class, new()
    {
        public List<T> _items { get; set; } = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
        }
        public void GetItem(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                Console.WriteLine($"Отримано предмет: {_items[index]}");
            }
            else
            {
                Console.WriteLine("Невірний індекс.");
            }
        }
    }
}
