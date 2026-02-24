using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_5
{
    internal class Warehouse
    {
        string[] _items = new string[10];
        public event Action<int, string> OnItemChanged;

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Length)
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 9.");
                }
                return $"Item at index {index}: {_items[index]}";
            }
            set
            {
                if (index < 0 || index >= _items.Length)
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 9.");
                }
                _items[index] = value;
                OnItemChanged?.Invoke(index, value);
            }

        }
    }
}
