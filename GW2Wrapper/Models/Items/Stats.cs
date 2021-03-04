namespace GW2Wrapper.Models.Items
{
    /// <summary>
    /// Represent the stat of an item
    /// </summary>
    public class Stats    
    {
        /// <summary>
        /// The id of the stat
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The attributes of the stat
        /// </summary>
        public Attributes Attributes { get; set; } 
    }
}