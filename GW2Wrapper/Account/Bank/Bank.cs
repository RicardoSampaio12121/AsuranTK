using System;
using System.Collections.Generic;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Bank;
using Newtonsoft.Json;

namespace GW2Wrapper.Account.Bank
{
    public class Bank
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string BankEndpoint = "v2/account/bank";


        public Bank(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public int GetItemAmount(int itemId)
        {
            var json = _apiConnector.ApiCall(BankEndpoint);
            var bank = _apiMapper.MapTop<List<BankItem>>(json);
            var count = 0;
            
            if (bank != null)
                foreach (var item in bank.Where(item => item != null))
                {
                    if (item.id == itemId)
                    {
                        count += item.count;
                    }
                }

            return count;
        }
        
        
    }
    
    
}