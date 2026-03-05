using System.Reflection;

namespace Projekt_6
{
    internal class ReflectionService
    {
        public static void InspectObject(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Object is null.");
                return;
            }

            Type type = obj.GetType();
            Console.WriteLine($"Type: {type.FullName}");

            var atributes = type.GetCustomAttribute(typeof(TransactionInfo), false);
            if (atributes != null)
            {
                var trancsactionInfo = (TransactionInfo)atributes;
                Console.WriteLine("TransactionInfo Attribute Found");
                Console.WriteLine($"Author: {trancsactionInfo.Author}");
                Console.WriteLine($"Version: {trancsactionInfo.Version}");
            }
            else
            {
                Console.WriteLine("No TransactionInfo attribute found.");
            }

            Console.WriteLine("Public Instance Properties:");
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                object? value = property.GetValue(obj);
                Console.WriteLine($"{property.Name}: {value}");
            }
            Console.WriteLine("Modifying private field:");

            var privateField = type.GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance);
            if (privateField != null)
            {
                privateField.SetValue(obj, "Modifited value");
                privateField.GetValue(obj);
                Console.WriteLine($"Private field value: {privateField.GetValue(obj)}");
            }
            else
            {
                Console.WriteLine("No private field found.");
            }
        }
    }
}