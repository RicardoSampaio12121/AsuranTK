using System;
using System.Net.Http;

namespace GW2Wrapper.Account
{
    public class Items
    {
        /// <summary>
        /// Returns the id of a given item name using the gw2spidy API since ANet doesn't support that
        /// on their API
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public int GetId(string itemName)
        {
            HttpClient client = new HttpClient();
            string url = @"";
            string requestUri = $@"http://www.gw2spidy.com/api/v0.9/json/item-search/{itemName.Replace(' ', '%')}";
           
            /*//substitude spaces in item name with %
            itemName = itemName.Replace(' ', '%');*/
            var stringTask = client.GetAsync(requestUri);
            stringTask.Wait();
            var result = stringTask.Result;
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);
            return 0;

        }
    }
}