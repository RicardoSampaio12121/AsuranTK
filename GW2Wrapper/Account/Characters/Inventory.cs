using System;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;

namespace GW2Wrapper.Account.Characters
{
    public class Inventory
    {

        private const string InventoryEndpoint = "v2/characters/Ricaplayss/inventory";
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;

        public Inventory(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        public int GetItemAmount(int itemId)
        {
            string json = _apiConnector.ApiCall(InventoryEndpoint);
            var inventory = _apiMapper.MapTop<Models.Account.Characters.Root>(json);
            int count = 0;
            
            foreach (var bag in inventory.bags)
            {
                foreach (var item in bag.inventory.Where(item => item != null))
                {
                    if (item.id == itemId)
                    {
                        count += item.count;
                    }
                }
            }
            
            return count;
        }
    }
}