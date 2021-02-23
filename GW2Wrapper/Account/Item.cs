using System;
using System.Collections.Generic;
using System.Net.Http;
using GW2Wrapper.Account.Characters;
using GW2Wrapper.Account.Materials;
using GW2Wrapper.Account.SharedInventory;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account;
using Newtonsoft.Json;

namespace GW2Wrapper.Account
{
    public class Item
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;

        public Item(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        /// <summary>
        /// Returns the id of a given item name using the gw2spidy API since ANet doesn't support that
        /// on their API
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        private static int GetId(string itemName)
        {
            HttpClient client = new HttpClient();
            string requestUri = $@"http://www.gw2spidy.com/api/v0.9/json/item-search/{itemName.Replace(' ', '%')}";

            var stringTask = client.GetAsync(requestUri);
            stringTask.Wait();
            var result = stringTask.Result;
            var json = result.Content.ReadAsStringAsync().Result;

            Root ids = JsonConvert.DeserializeObject<Root>(json);

            if (ids != null)
            {
                foreach (var l in ids.results)
                {
                    if (l.name == itemName)
                    {
                        return l.data_id;
                    }
                }
            }

            return 0;
        }
        
        /// <summary>
        /// Returns the amount of the given item that the user has in his account
        /// Goes through the bank, material storage and characters inventory
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public Dictionary<string, int> Search(string itemName)
        {
            var quantities = new Dictionary<string, int>();
            int itemId = GetId(itemName);
            
            //Search bank
            var bank = new Bank.Bank(_apiConnector, _apiMapper);
            quantities.Add("Bank", bank.GetItemAmount(itemId));

            //Search material storage
            var materialStorage = new Materials.Materials(_apiConnector, _apiMapper);
            quantities.Add("Material storage", materialStorage.GetAmount(itemId));

            //Search shared inventory
            var sharedInventory = new SharedInventory.SharedInventory(_apiConnector, _apiMapper);
            quantities.Add("Shared inventory", sharedInventory.GetAmount(itemId));

            //Search characters inventory
            var charsC = Factory.InitializeCharacters(_apiConnector, _apiMapper);
            var characters = charsC.GetCharacters();

            foreach (var character in characters.Name)
            {
                //Search in each character inventory
                var inventory = new Inventory(_apiConnector, _apiMapper);
                quantities.Add(character, inventory.GetItemAmount(character, itemId));
            }
            
            return quantities; 
        }
    }
}