using GW2Wrapper;

namespace Logic.Application.Commands
{
    public static class SearchCommand
    {
        public static void SearchItem(string itemName, string apiKey)
        {
            var mapper = Factory.InitializeMapper();
            var connector = Factory.InitializeConnector(apiKey);

            var item = Factory.InitializeItem(connector, mapper);
            item.GetAmount(itemName);
        }
    }
}