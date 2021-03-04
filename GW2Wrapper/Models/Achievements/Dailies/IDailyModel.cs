using System.Collections.Generic;
using Newtonsoft.Json;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    public interface IDailyModel
    {
        /// <summary>
        /// The id of the daily pve achievement
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } 
        
        /// <summary>
        /// The name of the daily pve achievement
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// The description of the daily pve achievement
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// The needed level for the daily pve achievement
        /// </summary>
        [JsonProperty("level")]
        public Level Level { get; set; }
        
        /// <summary>
        /// The information about the content an account
        /// needs to have to play this achievement
        /// </summary>
        [JsonProperty("required_access")]
        public List<string> RequiredAccess { get; set; }
    }
}