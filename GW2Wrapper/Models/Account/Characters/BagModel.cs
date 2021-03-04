using System.Collections.Generic;
using Newtonsoft.Json;

namespace GW2Wrapper.Models.Account.Characters
{
    /// <summary>
    /// Represents a single bag
    /// </summary>
    public class BagModel
    {
        /// <summary>
        /// The id of the bag
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The size of the bag
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// The item's in the bag
        /// </summary>
        [JsonProperty("inventory")]
        public List<InventoryItemModel> Items { get; set; } 
    }
}