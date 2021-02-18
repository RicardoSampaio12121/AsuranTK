using System.Collections.Generic;
using GW2Wrapper.Models.Account.Items;

namespace GW2Wrapper.Models.Account.Characters
{
    public class InventoryItem
    {
        public int id { get; set; } 
        public int count { get; set; } 
        public int charges { get; set; } 
        public string binding { get; set; } 
        public string bound_to { get; set; } 
        public List<int> upgrades { get; set; } 
        public List<int> upgrade_slot_indices { get; set; } 
        public List<int> infusions { get; set; } 
        public int? skin { get; set; } 
        public Stats stats { get; set; } 
    }
}