using GW2Wrapper;

namespace Logic.Application.Commands
{
    public static class CurrencyConverterCommands
    {
        private const int CoinsPerGold = 10000;
        public static int GoldToGems(int gold)
        {
            var exchanger = Factory.InitializeExchange();
            gold *= CoinsPerGold;
            return exchanger.GoldToGems(gold);
        }

        public static int GemsToGold(int gems)
        {
            var exchanger = Factory.InitializeExchange();
            return exchanger.GemsToGold(gems) / CoinsPerGold;
        }
    }
}