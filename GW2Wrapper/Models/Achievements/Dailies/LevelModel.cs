using Newtonsoft.Json;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    /// <summary>
    /// Represents the level for a daily achievement
    /// </summary>
    public class Level    
    {
        /// <summary>
        /// The minimum level
        /// </summary>
        [JsonProperty("min")]
        public int Minimum { get; set; } 
        
        
        /// <summary>
        /// The maximum level
        /// </summary>
        [JsonProperty("max")]
        public int Maximum { get; set; } 
    }
}