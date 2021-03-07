namespace GW2Wrapper.Models.Achievements
{
    /// <summary>
    /// Represents the rewards of an achievement
    /// If type = coins only count has a value
    /// If type = Item only id and count has a value
    /// If type = Mastery only id and region has a value
    /// If type =  title only id has a value
    /// </summary>
    public class RewardModel
    {
        /// <summary>
        /// The type of reward
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The id of the reward
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The number of coins to be rewarded
        /// </summary>
        public int Count { get; set; } 
        
        /// <summary>
        /// The region a mastery point applies to
        /// </summary>
        public string Region { get; set; } 
    }
}