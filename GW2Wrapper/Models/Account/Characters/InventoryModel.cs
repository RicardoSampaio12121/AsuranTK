using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.Characters
{
    /// <summary>
    /// Represents the inventory of a character
    /// </summary>
    public class InventoryModel    
    {
        /// <summary>
        /// The list of bags
        /// </summary>
        public List<BagModel> Bags { get; set; } 
    }
    
}