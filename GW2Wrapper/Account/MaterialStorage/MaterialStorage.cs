using System.Collections.Generic;
using System.Linq;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account.MaterialStorage;

namespace GW2Wrapper.Account.MaterialStorage
{
    /// <summary>
    /// Contains functions to interact with the material storage endpoint
    /// </summary>
    public class MaterialStorage
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string MaterialsEndpoint = "v2/account/materials";
        
        public MaterialStorage(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        private IEnumerable<MaterialStorageItemModel> Get()
        {
            var json = _apiConnector.ApiCall(MaterialsEndpoint);
            return _apiMapper.MapTop<List<MaterialStorageItemModel>>(json);
        }

        public int GetMaterialCount(int itemId)
        {
            var materialStorage = Get();

            foreach (var material in materialStorage.Where(material => material != null))
            {
                if (material.Id == itemId)
                {
                    return material.Count;
                }
            }
            return 0;
        }
    }
}