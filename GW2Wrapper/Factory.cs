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
    }
}