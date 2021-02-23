/*using System.Collections.Generic;
using GW2Wrapper;
using GW2Wrapper.Account;
using Logic.Application.Commands;

namespace Logic.Application
{
    public static class CommandsHandler
    {
        public static T Do<T>(string input, string apiKey)
        {
            
            var comParam = Utils.ParseCommand(input);
            
            switch (comParam.com)
            {
                case "search": //This command will search for an item and give the amount the account has
                    return SearchCommand.SearchItem(comParam.parameter, apiKey);
            }
        }   
    }
}*/