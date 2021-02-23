namespace GW2Wrapper.Models.Account
{
    public class SharedInventory
    {
        public int id { get; set; }
        public int count { get; set; }
        public int charges { get; set; }
        public int skin { get; set; }
        public int[] upgrades { get; set; }
        public int[] infusions { get; set; }
        public string binding { get; set; }
    }
}