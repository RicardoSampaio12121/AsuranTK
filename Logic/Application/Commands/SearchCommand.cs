using System.Collections.Generic;
using GW2Wrapper;

namespace Logic.Application.Commands
{
    public static class SearchCommand
    {
        public static Dictionary<string, int> Item(string itemName, string apiKey)
        {
            var mapper = Factory.InitializeMapper();
            var connector = Factory.InitializeConnector(apiKey);

            var item = Factory.InitializeItem(connector, mapper);
            return item.Search(itemName, apiKey);
        }
    }
}