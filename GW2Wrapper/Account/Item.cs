using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Characters;
using Newtonsoft.Json;
using Root = GW2Wrapper.Models.Account.Root;

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
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public Dictionary<string, int> Search(string itemName, string apiKey)
        {
            var output = new Dictionary<string, int>();
            var itemId = GetId(itemName);
            
            var bank                      = Factory.InitializeBank(apiKey, _apiMapper);
            var materialStorage   = Factory.InitializeMaterials(apiKey, _apiMapper);
            var sharedInventory           = Factory.InitializeSharedInventory(apiKey, _apiMapper);
            var accountCharacters         = Factory.InitializeCharacters(apiKey, _apiMapper);
            var inventory                 = Factory.InitializeInventory(apiKey, _apiMapper);

            int bankAmount = 0, materialStorageAmount = 0, sharedInventoryAmount = 0;
            AccountCharacters characters = null;
            
            Parallel.Invoke
            (
                () => bankAmount = bank.GetItemAmount(itemId),
                () => materialStorageAmount = materialStorage.GetAmount(itemId),
                () => sharedInventoryAmount = sharedInventory.GetAmount(itemId),
                () => characters = accountCharacters.GetCharacters()
            );
            
            output.Add("Bank", bankAmount);
            output.Add("Material storage", materialStorageAmount);
            output.Add("Shared inventory", sharedInventoryAmount);
            
            foreach (var character in characters.Name)
            {
                //Search in each character inventory
                output.Add(character, inventory.GetItemAmount(character, itemId));
            }
            
            return output; 
        }
    }
}