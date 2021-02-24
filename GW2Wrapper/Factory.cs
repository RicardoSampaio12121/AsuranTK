using GW2Wrapper.Account;
using GW2Wrapper.Account.Bank;
using GW2Wrapper.Account.Characters;
using GW2Wrapper.Account.Materials;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account;

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

        public static Characters InitializeCharacters(string apiKey, IMapper apiMapper)
        {
            return new Characters(InitializeConnector(apiKey), apiMapper);
        }

        public static Bank InitializeBank(string apiKey, IMapper apiMapper)
        {
            return new Bank(InitializeConnector(apiKey), apiMapper);
        }

        public static Materials InitializeMaterials(string apiKey, IMapper apiMapper)
        {
            return new Materials(InitializeConnector(apiKey), apiMapper);
        }

        public static Account.SharedInventory.SharedInventory InitializeSharedInventory(string apiKey, IMapper apiMapper)
        {
            return new Account.SharedInventory.SharedInventory(InitializeConnector(apiKey), apiMapper);
        }

        public static Inventory InitializeInventory(string apiKey, IMapper apiMapper)
        {
            return new Inventory(InitializeConnector(apiKey), apiMapper);
        }
        
    }
}