using System.Collections.Generic;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    /// <summary>
    /// Represents a single fractal daily achievement
    /// </summary>
    public class FractalDailyModel : IDailyModel
    {
        /*/// <summary>
        /// The id of the achievement
        /// </summary>
        public int Id { get; set; } 
        
        /// <summary>
        /// The name of the achievement
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The description of the achievement
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// The level required fot the achievement
        /// </summary>
        public Level Level { get; set; }
        
        /// <summary>
        /// The requirements for the achievement
        /// </summary>
        public List<string> RequiredAccess { get; set; } = new List<string>();*/
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public List<string> RequiredAccess { get; set; }
    }
}