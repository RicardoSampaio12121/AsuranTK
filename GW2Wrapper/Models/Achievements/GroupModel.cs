using System.Collections.Generic;
using Newtonsoft.Json;

namespace GW2Wrapper.Models.Achievements
{
    public class GroupModel
    {
        /// <summary>
        /// The group's GUID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// The group name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The group's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A number describing where to sort this group among other groups
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// An array containing a number of category IDs that this group contains
        /// </summary>
        [JsonProperty("categories")]
        public List<int> Categories { get; set; }
    }
}