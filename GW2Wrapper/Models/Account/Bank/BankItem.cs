using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.Bank
{
    public class BankItem
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
        
    }
}