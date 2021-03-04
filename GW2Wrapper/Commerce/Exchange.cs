/*
 * Author: Ricardo Sampaio
 * Email: ricardo_cs@outlook.pt
 * Date: 25/02/2021
 */

using System;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Commerce;

namespace GW2Wrapper.Commerce
{
    /// <summary>
    /// This class contains functions to work with the exchange endpoint and it's sub-endpoints
    /// </summary>
    public class Exchange
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string DefaultEndpoint = "v2/commerce/exchange/";
        
        public Exchange(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public int GoldToGems(int gold)
        {
            var json = _apiConnector.ApiCall($"{DefaultEndpoint}coins?quantity={gold}");
            var output = _apiMapper.MapTop<ExchangeModel>(json);
            return output.Quantity;
        }

        public int GemsToGold(int gems)
        {
            Console.WriteLine(gems.ToString());
            var json = _apiConnector.ApiCall($"{DefaultEndpoint}gems?quantity={gems}");
            var output = _apiMapper.MapTop<ExchangeModel>(json);
            return output.Quantity;
        }
    }
}