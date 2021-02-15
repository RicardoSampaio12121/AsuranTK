using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;

namespace GW2Wrapper.Account
{
    public class Account
    {
        private const string AccountEndPoint = "v2/account";
        private IConnector _apiConnector;
        private IMapper _apiMapper;

        public Account(IConnector apiConnector, IMapper apiMapper)
        {
            this._apiConnector = apiConnector;
            this._apiMapper = apiMapper;
        }

        public Models.Account.Account GetData()
        {
            return this._apiMapper.MapTop<Models.Account.Account>(_apiConnector.ApiCall(AccountEndPoint));
        }
    }
}