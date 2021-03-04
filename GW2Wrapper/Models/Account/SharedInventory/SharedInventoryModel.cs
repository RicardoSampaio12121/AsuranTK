using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.SharedInventory
{
    /// <summary>
    /// Represents the Shared inventory
    /// </summary>
    public class SharedInventoryModel
    {
        /// <summary>
        /// The items in the shared inventory
        /// </summary>
        public List<SharedInventoryItemModel> Items { get; set; }
    }
}