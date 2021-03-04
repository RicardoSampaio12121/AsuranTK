using System.Collections.Generic;
using GW2Wrapper.Models.Items;

namespace GW2Wrapper.Models.Account.Characters
{
    /// <summary>
    /// Represents a single item in a character inventory
    /// </summary>
    public class InventoryItemModel
    {
        /// <summary>
        /// The id of the item
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The amount of items in the item stack
        /// </summary>
        public int Count { get; set; } 
        
        /// <summary>
        /// The amount of charges remaining in the item(optional)
        /// </summary>
        public int Charges { get; set; } 
        
        /// <summary>
        /// The current binding of the item(account or character)(optional)
        /// </summary>
        public string Binding { get; set; } 
        
        /// <summary>
        /// The name of the character the item is bound to(optional)
        /// </summary>
        public string BoundTo { get; set; } 
        
        /// <summary>
        /// The id's of the upgrade components in an item(optional)
        /// </summary>
        public List<int> Upgrades { get; set; } 
        
        /// <summary>
        /// The id's of the infusions applied to the item(optional)
        /// </summary>
        public List<int> Infusions { get; set; } 
        
        /// <summary>
        /// The skin id of the item(optional)
        /// </summary>
        public int? Skin { get; set; } 
        
        /// <summary>
        /// The information of the stat of the item(optional)
        /// </summary>
        public Stats Stats { get; set; } 
    }
}