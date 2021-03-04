using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using System.Linq;
using GW2Wrapper.Models.Account.SharedInventory;

namespace GW2Wrapper.Account.SharedInventory
{
    public class SharedInventory
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string SharedInventoryEndpoint = "v2/account/inventory";

        public SharedInventory(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private List<SharedInventoryItemModel> Get()
        {
            var json =_apiConnector.ApiCall(SharedInventoryEndpoint);
            return _apiMapper.MapTop<List<Models.Account.SharedInventory.SharedInventoryItemModel>>(json);

        }

        public int GetItemCount(int itemId)
        {
            var sharedInventory = Get();
            int count = 0;

            foreach (var item in sharedInventory.Where(item => item != null))
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