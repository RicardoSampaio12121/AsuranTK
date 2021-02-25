using System.Collections.Generic;
using System.Threading.Tasks;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.Characters;

namespace GW2Wrapper.Account
{
    public class Account
    {
        private const string AccountEndPoint = "v2/account";
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;

        public Account(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public Models.Account.Account GetData()
        {
            return _apiMapper.MapTop<Models.Account.Account>(_apiConnector.ApiCall(AccountEndPoint));
        }
        
        
        
    }
}