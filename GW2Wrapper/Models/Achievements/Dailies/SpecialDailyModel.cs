using System.Collections.Generic;

namespace GW2Wrapper.Models.Achievements.Dailies
{
    public class SpecialDailyModel : IDailyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public List<string> RequiredAccess { get; set; }
    }
}