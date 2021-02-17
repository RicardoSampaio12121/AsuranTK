using GW2Wrapper;
using GW2Wrapper.Account;
using Logic.Application.Commands;

namespace Logic.Application
{
    public static class CommandsHandler
    {
        public static void Do(string input, string apiKey)
        {
            var comParam = Utils.ParseCommand(input);
            
            
            switch (comParam.com)
            {
                case "search": //This command will search for an item and give the amount the account has
                    SearchCommand.SearchItem(comParam.parameter, apiKey);
                    break;
            }
        }   
    }
}