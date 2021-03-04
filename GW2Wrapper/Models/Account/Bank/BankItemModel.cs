using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.Bank
{
    /// <summary>
    /// Represents a single item stored in the bank
    /// </summary>
    public class BankItemModel
    {
        /// <summary>
        /// The id of the item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The amount of items in the item stack
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// The amount of charges remaining in the item(optional)
        /// </summary>
        public int Charges { get; set; }
        /// <summary>
        /// The current binding of the item(account or character)(optional)
        /// </summary>
        public string Binding { get; set; }
        /// <summary>
        /// The character the item is bound to(if it is bound to a character)(optional)
        /// </summary>
        public string BoundTo { get; set; }
        /// <summary>
        /// The id's of runes and signets applied to the item(optional)
        /// </summary>
        public List<int> Upgrades { get; set; }
        /// <summary>
        /// The id's of the infusions applied to the item(optional)
        /// </summary>
        public List<int> Infusions { get; set; }
        /// <summary>
        /// The skin applied to the item(optional)
        /// </summary>
        public int? Skin { get; set; }
       
    }
}