using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GW2Wrapper.Models.Achievements
{
    /// <summary>
    /// Represents an achievement
    /// </summary>
    public class AchievementModel
    {
        /// <summary>
        /// The id of the achievement
        /// </summary>
        public int Id { get; set; } 
        
        /// <summary>
        /// The icon of the achievement
        /// </summary>
        public string Icon { get; set; }
        
        /// <summary>
        /// The name of the achievement
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The description of the achievement
        /// </summary>
        public string Description { get; set; } 
        
        /// <summary>
        /// The achievement requirements as listed in game
        /// </summary>
        public string Requirement { get; set; } 
        
        /// <summary>
        /// The achievement description prior to unlocking it
        /// </summary>
        public string LockedText { get; set; } 
        
        /// <summary>
        /// The achievement type(default or item set)
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// Achievement categories
        /// </summary>
        public List<string> Flags { get; set; }
        
        /// <summary>
        /// The achievement tiers
        /// </summary>
        public List<TierModel> Tiers { get; set; }
        
        /// <summary>
        /// The achievement id's required to access this achievement
        /// </summary>
        public List<int> Prerequesites { get; set; }
        
        /// <summary>
        /// The rewards of this achievement
        /// </summary>
        public List<RewardModel> Rewards { get; set; }
        
        /// <summary>
        /// Information about the progression towards the achievement
        /// </summary>
        public List<BitModel> Bits { get; set; }

        /// <summary>
        /// The maximum number of AP that can be rewarded
        /// </summary>
        public int PointCap { get; set; } = -1;
    }
    
}