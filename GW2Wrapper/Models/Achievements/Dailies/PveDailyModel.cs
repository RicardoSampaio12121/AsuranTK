using System.Collections.Generic;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    /// <summary>
    /// Represents a pve daily achievement
    /// </summary>
    public class PveDaily : IDailyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public List<string> RequiredAccess { get; set; }
    }
}