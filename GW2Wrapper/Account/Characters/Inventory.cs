using System;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Characters;

namespace GW2Wrapper.Account.Characters
{
    /// <summary>
    /// This class has functions to interact with the characters inventory endpoint of the api
    /// </summary>
    public class Inventory
    {
        private const string InventoryEndpoint = "v2/characters/";
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiConnector"></param>
        /// <param name="apiMapper"></param>
        public Inventory(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        
        /// <summary>
        /// Builds the endpoint string with the character name
        /// </summary>
        /// <param name="characterName"></param>
        /// <returns></returns>
        private string ConstructEndpoint(string characterName)
        {
            return $"{InventoryEndpoint}{characterName}/inventory";
        }


        private InventoryModel Get(string characterName)
        {
            var endpoint = ConstructEndpoint(characterName);
            var json = _apiConnector.ApiCall(endpoint);
            return _apiMapper.MapTop<InventoryModel>(json);
        }
        
        /// <summary>
        /// Gets the amount of a given item a character has in his inventory
        /// </summary>
        /// <param name="characterName"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public int GetItemCount(string characterName, int itemId)
        {
            var inventory = Get(characterName);
            var count = 0;
            
            foreach (var bag in inventory.Bags.Where(bag => bag != null))
            {
                foreach (var item in bag.Items.Where(item => item != null))
                {
                    if (item.Id == itemId)
                    {
                        count += item.Count;
                    }
                }
            }
            return count;
        }
    }
}