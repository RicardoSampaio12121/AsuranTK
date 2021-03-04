using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account;
using GW2Wrapper.Models.Account.Characters;
using Newtonsoft.Json;

namespace GW2Wrapper.Account.Characters
{
    /// <summary>
    /// This class contains function to interact with the characters endpoint of the api
    /// </summary>
    public class Characters
    {
        private const string CharactersEndpoint = "v2/characters";
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiConnector"></param>
        /// <param name="apiMapper"></param>
        public Characters(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        /// <summary>
        /// Gets all the characters of an account
        /// </summary>
        /// <returns></returns>
        public AccountCharactersModel Get()
        {
            var json = _apiConnector.ApiCall(CharactersEndpoint);
            var characters = JsonConvert.DeserializeObject<List<string>>(json);
            return new AccountCharactersModel {Name = characters};;
          
        }
    }
}