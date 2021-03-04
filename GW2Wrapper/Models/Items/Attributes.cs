namespace GW2Wrapper.Models.Items
{
    /// <summary>
    /// Represents the attributes of the stats
    /// </summary>
    public class Attributes
    {
        public int Power { get; set; } 
        public int Precision { get; set; }
        public int Toughness { get; set; }
        public int Vitality { get; set; }
        public int CriticalDamage { get; set; }
        public int ConditionDamage { get; set; }
        public int ConditionDuration { get; set; }
        public int Healing { get; set; }
        public int BoonDuration { get; set; }
    }
}