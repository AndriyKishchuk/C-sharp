using Project_9;

class Program
{
    public static async Task Main(string[] args)
    {
        BonusAccount bonusAccount = new BonusAccount();

        string[] apis =
        {
            "API_1", "API_2", "API_3", "API_4", "API_5",
            "API_6", "API_7", "API_8", "API_9", "API_10"
        };
        var tasks = new Task[100];

        Task consumer = Task.Run(() =>
        {
            foreach (var transaction in bonusAccount.Transactions.GetConsumingEnumerable())
            {
                Console.WriteLine($"LOG {transaction}");
            }
        });

        for (int i = 0; i < 100; i++)
        {
            string api = apis[i % 10];
            tasks[i] = Task.Run(() => bonusAccount.Add(api));
        }
        await Task.WhenAll(tasks);

        bonusAccount.Transactions.CompleteAdding();

        await consumer;

        Console.WriteLine($"Final Balance: {bonusAccount.Balance}");
       



    }

}