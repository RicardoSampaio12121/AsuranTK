using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.Characters
{
    public class Attributes    {
        public int Power { get; set; } 
        public int Precision { get; set; } 
        public int CritDamage { get; set; } 
    }

    public class Stats    {
        public int id { get; set; } 
        public Attributes attributes { get; set; } 
    }

    public class Inventory    {
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

    public class Bag    {
        public int id { get; set; } 
        public int size { get; set; } 
        public List<Inventory> inventory { get; set; } 
    }

    public class Root    {
        public List<Bag> bags { get; set; } 
    }
}