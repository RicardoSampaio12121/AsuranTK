using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.MaterialStorage
{
    /// <summary>
    /// Represents the material storage
    /// </summary>
    public class MaterialStorageModel
    {
        /// <summary>
        /// The item's of the material storage
        /// </summary>
        public List<MaterialStorageItemModel> Items { get; set; } = new List<MaterialStorageItemModel>();
    }
}

    
