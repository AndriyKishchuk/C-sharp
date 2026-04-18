namespace Projekt_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var exchangeService = new RandomExchangeService();
            var bot = new TradingBot(exchangeService);

            string? symbol = "BTCUSD";
            decimal averagePrice = 50000m;

            for (int i = 0; i < 10; i++)
            {
                string action = bot.ExecuteStrategy(symbol, averagePrice);
                Console.WriteLine($"Action for {symbol} at average price {averagePrice}: {action}");
            }
        }
    }
}

