using System;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Characters;

namespace GW2Wrapper.Account.Characters
{
    public class Inventory
    {

        private readonly string InventoryEndpoint = "v2/characters/";
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;

        public Inventory(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private string ConstructEndpoint(string characterName)
        {
            return $"{InventoryEndpoint}{characterName}/inventory";
        }
        
        public int GetItemAmount(string characterName, int itemId)
        {
            string endpoint = ConstructEndpoint(characterName);
            string json = _apiConnector.ApiCall(endpoint);
            var inventory = _apiMapper.MapTop<Models.Account.Characters.Root>(json);
            int count = 0;
            
            foreach (var bag in inventory.bags.Where(bag => bag != null))
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