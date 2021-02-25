using System.Collections.Generic;
using GW2Wrapper;

namespace Logic.Application.Commands
{
    public static class SearchCommand
    {
        public static Dictionary<string, int> Item(string itemName, string apiKey)
        {
            var item = Factory.InitializeItem(apiKey);
            return item.SearchInAccount(itemName);
        }
    }
}