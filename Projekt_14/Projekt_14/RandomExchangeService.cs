namespace Projekt_14
{
    public class RandomExchangeService : IExchangeService
    {
        private readonly Random _random = new();

        public decimal GetCurrentPrice(string symbol)
        {
            return _random.Next(800, 1201);
        }
    }
}
