using System;
using System.Net;
class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2.5));
            var task = Task.Run(() => Task.WhenAll(GetBinancePriceAsync(cts.Token), GetCoinbasePriceAsync(cts.Token), GetKrakenPriceAsync(cts.Token)));
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Searching... Press 'S' to cancel");
            string? input = Console.ReadLine();
            if (input == "S" || input == "s")
            {
                cts.Cancel();
                Console.WriteLine("Search cancelled by user.");
                return;
            }
            await task;
            var results = task.Result;
            var totalPrice = results.Sum();
            var averagePrice = totalPrice / results.Length;
            Console.WriteLine($"Average price: {averagePrice}");

            stopWatch.Stop();
            Console.WriteLine($"Execution time: {stopWatch.ElapsedMilliseconds} ms");


            var cts2 = new CancellationTokenSource(TimeSpan.FromSeconds(2.5));
            var binanceTask = GetBinancePriceAsync(cts2.Token);
            var coinbaseTask = GetCoinbasePriceAsync(cts2.Token);
            var krakenTask = GetKrakenPriceAsync(cts2.Token);

            var task2 = Task.Run(() => Task.WhenAny(binanceTask, coinbaseTask, krakenTask));
            await task2;
            var firstCompletedTask = task2.Result;
            string exchangeName = firstCompletedTask == binanceTask ? "Binance" : firstCompletedTask == coinbaseTask ? "Coinbase" : "Kraken";
            Console.WriteLine($"First completed exchange: {exchangeName} with price {firstCompletedTask.Result}");
        }

        catch (OperationCanceledException)
        {
            Console.WriteLine("Network timeout: exchanges are not responding");
        }
    }

    public static async Task<int> GetBinancePriceAsync(CancellationToken token)
    {
        Random random = new Random();
        int values = random.Next(60000, 65000);
        var delay = random.Next(500, 4000);
        await Task.Delay(delay, token);
        return values;
    }

    public static async Task<int> GetCoinbasePriceAsync(CancellationToken token)
    {
        Random random = new Random();
        int values = random.Next(60000, 65000);
        var delay = random.Next(500, 4000);
        await Task.Delay(delay, token);
        return values;
    }

    public static async Task<int> GetKrakenPriceAsync(CancellationToken token)
    {
        Random random = new Random();
        int values = random.Next(60000, 65000);
        var delay = random.Next(500, 4000);
        await Task.Delay(delay, token);
        return values;
    }

}
