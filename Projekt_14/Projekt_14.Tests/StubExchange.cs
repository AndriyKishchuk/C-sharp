namespace Projekt_14.Tests
{
    public class StubExchange : IExchangeService
    {
        private readonly decimal _amount;

        public StubExchange(decimal amount)
        {
            _amount = amount;
        }

        public decimal GetCurrentPrice(string symbol)
        {
            return _amount;
        }
    }
}
