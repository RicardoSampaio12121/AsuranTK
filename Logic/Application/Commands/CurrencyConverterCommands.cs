using GW2Wrapper;

namespace Logic.Application.Commands
{
    public static class CurrencyConverterCommands
    {
        public static int GoldToGems(int gold)
        {
            var exchange = Factory.InitializeExchange();
            return exchange.GoldToGems(gold);
        }
    }
}