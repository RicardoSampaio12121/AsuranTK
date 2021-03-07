using System.Collections.Generic;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    /// <summary>
    /// Represents the daily achievements for pve, pvp, wvw, fractals and special events
    /// </summary>
    public class DailyAchievementsModel
    {
        /// <summary>
        /// The daily pve achievements
        /// </summary>
        public List<PveDailyModel> Pve { get; set; }
        
        /// <summary>
        /// The daily pvp achievements
        /// </summary>
        public List<PvpDailyModel> Pvp { get; set; }
        
        /// <summary>
        /// The daily wvw achievements
        /// </summary>
        public List<WvwDailyModel> Wvw { get; set; }
        
        /// <summary>
        /// The daily fractals achievements
        /// </summary>
        public List<FractalDailyModel> Fractals { get; set; }
        
        /// <summary>
        /// The daily special events achievements
        /// </summary>
        public List<SpecialDailyModel> Special { get; set; }
    }
}