using System;
using System.Net.Http;
using GW2Wrapper.Account.Characters;
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
        public int GetAmount(string itemName)
        {
            int itemId = GetId(itemName);
            
            //Search bank
            
            
            //Search material storage
            
            
            //Search characters inventory

            var charsC = Factory.InitializeCharacters(_apiConnector, _apiMapper);
            var characters = charsC.GetCharacters();

            //foreach (var character in characters.Name)
            //{
                //Search in each character inventory
            var inventory = new Inventory(_apiConnector, _apiMapper);
            int i = inventory.GetItemAmount(itemId);
            Console.WriteLine(i.ToString());
            //}
            return 1;
        }
    }
}