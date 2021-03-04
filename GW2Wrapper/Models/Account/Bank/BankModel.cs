using System.Collections.Generic;

namespace GW2Wrapper.Models.Account.Bank
{
    /// <summary>
    /// Represents the bank
    /// </summary>
    public class BankModel
    {
        /// <summary>
        /// The item's in the bank
        /// </summary>
        public List<BankItemModel> BankItem { get; set; } = new List<BankItemModel>();
    }

   


}