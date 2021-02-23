using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GW2Wrapper.Account.SharedInventory
{
    public class SharedInventory
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string sharedInventoryEndpoint = "v2/account/inventory";

        public SharedInventory(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private IEnumerable<Models.Account.SharedInventory> GetSharedInventory()
        {
            var json =_apiConnector.ApiCall(sharedInventoryEndpoint);
            return _apiMapper.MapTop<List<Models.Account.SharedInventory>>(json);

        }

        public int GetAmount(int itemId)
        {
            var sharedInventory = GetSharedInventory();
            int count = 0;    
            
            foreach (var item in sharedInventory.Where(item => item != null))
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