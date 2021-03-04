using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GW2Wrapper.Models.Account.SharedInventory
{
    public class SharedInventoryItemModel
    {
        /// <summary>
        /// The id of the item
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// The amount of items in the stack
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        
        /// <summary>
        /// The amount of remaining charges of the item(optional)
        /// </summary>
        [JsonProperty("charges")]
        public int Charges { get; set; }
        
        /// <summary>
        /// The skin applied to the item(optional)
        /// </summary>
        [JsonProperty("skin")]
        public int Skin { get; set; }
        
        /// <summary>
        /// The id's of runes and signets applied to the item(optional)
        /// </summary>
        [JsonProperty("upgrades")]
        public List<int> Upgrades { get; set; }
        
        /// <summary>
        /// The id's of infusions applied to the item(optional)
        /// </summary>
        [JsonProperty("infusions")]
        public List<int> Infusions { get; set; }
        
        /// <summary>
        /// The current binding of the item(optional)
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get; set; }
        
    }
}