using System.Text.Json;
using Projekt_6;
class Program
{
    static void Main(string[] args)
    {
        var transaction = new Transaction(1, 230.3m, "USD", "Vasia", "sec1223");
        var transaction_1 = new Transaction(2, 1230.3m, "Euro", "Kolya", "nu2a3333");

        Transaction[] transactions = { transaction, transaction_1 };
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonSerialize = JsonSerializer.Serialize(transactions, options);
        File.WriteAllText("users.json", jsonSerialize);
        var fileRead = File.ReadAllText("users.json");

        var jsonDeserialize = JsonSerializer.Deserialize<Transaction[]>(fileRead);
        foreach (var json in jsonDeserialize)
        {
            Console.WriteLine();
            Console.WriteLine($"Id: {json.Id}");
            Console.WriteLine($"Amount: {json.Amount}");
            Console.WriteLine($"Currency: {json.Currency}");
            Console.WriteLine($"SenderName: {json.SenderName}");
            Console.WriteLine($"SecretAuthCode: {json.SecretCode ?? "NULL"}");
        }
        Console.WriteLine("-----");
        ReflectionService.InspectObject(transaction);
    }
}