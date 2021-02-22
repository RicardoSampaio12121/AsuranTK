using System;
using System.Collections.Generic;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.MaterialStorage;

namespace GW2Wrapper.Account.Materials
{
    public class Materials
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string MaterialsEndpoint = "v2/account/materials";
        
        public Materials(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private IEnumerable<MaterialStorageItem> GetMaterialStorage()
        {
            var json = _apiConnector.ApiCall(MaterialsEndpoint);
            var output = _apiMapper.MapTop<List<MaterialStorageItem>>(json);
            return output;
        }
        
        public int GetAmount(int itemId)
        {
            var materialStorage = GetMaterialStorage();
            return materialStorage.Where(material => material.id == itemId).Select(material => material.count).First();
        }
    }
}