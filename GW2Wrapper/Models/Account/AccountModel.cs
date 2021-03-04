using System.Collections.Generic;

namespace GW2Wrapper.Models.Account
{
    /// <summary>
    /// Represents an account
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// The id of the account
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// The name of the account
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The age of the account
        /// </summary>
        public int Age { get; set; }
        
        /// <summary>
        /// The id of the home world the account is assigned to
        /// </summary>
        public int World { get; set; }
        
        /// <summary>
        /// The list of guilds assigned to the given account
        /// </summary>
        public List<string> Guilds { get; set; }
        
        /// <summary>
        /// The list of guilds the account is leader of
        /// </summary>
        public string GuildLeader { get; set; }
        
        /// <summary>
        /// The timestamp of when the account was created
        /// </summary>
        public string Created { get; set; }
        
        /// <summary>
        /// The list of the content the account has access to
        /// </summary>
        public List<string> Access { get; set; }
        
        /// <summary>
        /// The information if the player has bought the commander tag
        /// </summary>
        public bool Commander { get; set; }
        
        /// <summary>
        /// The fractal level of the account
        /// </summary>
        public int FractalLever { get; set; }
        
        /// <summary>
        /// The daily AP the account has
        /// </summary>
        public int DailyAp { get; set; }
        
        /// <summary>
        /// The monthly AP the account has
        /// </summary>
        public int MonthlyAp { get; set; }
        
        /// <summary>
        /// The WvW rank of the account
        /// </summary>
        public int WvWRank { get; set; }
        
        /// <summary>
        /// The standard timestamp of when the account was last modified
        /// </summary>
        public string LastModified { get; set; }
    }
}