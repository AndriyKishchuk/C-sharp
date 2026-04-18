namespace Projekt_14.Tests
{
    public class TradingBotTests
    {
        [Fact]
        public void Test_Should_Buy()
        {
            //Arange
            var stubExchange = new StubExchange(85m);
            var bot = new TradingBot(stubExchange);
            //Act
            var result = bot.ExecuteStrategy("BTC", 100m);
            //Assert
            Assert.Equal("Buy", result);
        }

        [Fact]
        public void Test_Should_Sell()
        {
            //Arange
            var stubExchange = new StubExchange(115m);
            var bot = new TradingBot(stubExchange);
            //Act
            var result = bot.ExecuteStrategy("BTC", 100m);
            //Assert
            Assert.Equal("Sell", result);
        }

        [Fact]
        public void Test_Should_Hold()
        {
            //Arange
            var stubExchange = new StubExchange(105m);
            var bot = new TradingBot(stubExchange);
            //Act
            var result = bot.ExecuteStrategy("BTC", 100m);
            //Assert
            Assert.Equal("Hold", result);
        }
    }
}
