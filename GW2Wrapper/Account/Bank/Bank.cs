/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 18/02/2021
 * Resume: This file contains a class to interact with the v2/account/bank endpoint
 */

using System.Collections.Generic;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Bank;

namespace GW2Wrapper.Account.Bank
{
    /// <summary>
    /// Contains functions to interact with the bank endpoint of the api
    /// </summary>
    public class Bank
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string BankEndpoint = "v2/account/bank";

        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiConnector"></param>
        /// <param name="apiMapper"></param>
        public Bank(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private IEnumerable<BankItemModel> Get()
        {
            var json = _apiConnector.ApiCall(BankEndpoint);
            return _apiMapper.MapTop<List<BankItemModel>>(json);
        }
        
        /// <summary>
        /// Gets the amount of a given item that are in the account bank
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public int GetItemAmount(int itemId)
        {

            var bank = Get();
            var count = 0;

            if (bank == null) return count;
            foreach (var item in bank.Where(item => item != null))
            {
                if (item.Id == itemId)
                {
                    count += item.Count;
                }
            }
            return count;
        }
    }
}