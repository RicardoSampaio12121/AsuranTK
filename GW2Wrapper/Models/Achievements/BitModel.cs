namespace GW2Wrapper.Models.Achievements
{
    /// <summary>
    /// Represents information towards the completion of an
    /// achievement
    /// </summary>
    public class BitModel
    {
        /// <summary>
        /// The type of the bit
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The id of the bit
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The text for the bit
        /// </summary>
        public string Text { get; set; }
    }
}