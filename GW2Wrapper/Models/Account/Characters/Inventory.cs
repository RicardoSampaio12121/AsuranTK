using System.Collections.Generic;
using GW2Wrapper.Models.Account.Items;

namespace GW2Wrapper.Models.Account.Characters
{
    
    public class Bag    
    {
        public int id { get; set; } 
        public int size { get; set; } 
        public List<InventoryItem> inventory { get; set; } 
    }

    public class Root    {
        public List<Bag> bags { get; set; } 
    }
}