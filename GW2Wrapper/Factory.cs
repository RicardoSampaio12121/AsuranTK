using GW2Wrapper.Account;
using GW2Wrapper.Account.Characters;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;

namespace GW2Wrapper
{
    public static class Factory
    {
        public static Account.Account InitializeAccount(IConnector apiConnector, IMapper apiMapper)
        {
            return new Account.Account(apiConnector, apiMapper);
        }

        public static IMapper InitializeMapper()
        {
            return new Mapper.Mapper();
        }

        public static IConnector InitializeConnector(string apiKey)
        {
            return new Connector.Connector(apiKey);
        }

        public static Item InitializeItem(IConnector apiConnector, IMapper apiMapper)
        {
            return new Item(apiConnector, apiMapper);
        }

        public static Characters InitializeCharacters(IConnector apiConnector, IMapper apiMapper)
        {
            return new Characters(apiConnector, apiMapper);
        }
    }
}