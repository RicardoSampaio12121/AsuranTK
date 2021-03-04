namespace GW2Wrapper.Models.Account.MaterialStorage
{
    /// <summary>
    /// Represents a single item of the material storage
    /// </summary>
    public class MaterialStorageItemModel
    {
        /// <summary>
        /// The id of the item
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The material category of the item
        /// </summary>
        public int Category { get; set; } 
        
        /// <summary>
        /// The amount of the material stored
        /// </summary>
        public int Count { get; set; } 
        
        /// <summary>
        /// The current binding of the item(account or omitted)(optional)
        /// </summary>
        public string Binding { get; set; } 
    }
}