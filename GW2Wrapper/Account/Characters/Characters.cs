using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Account;
using GW2Wrapper.Models.Account.Characters;
using Newtonsoft.Json;

namespace GW2Wrapper.Account.Characters
{
    public class Characters
    {
        private const string CharactersEndpoint = "v2/characters";
        //private const string CharactersInventoryEndpoint = "v2/characters/"
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;

        public Characters(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        public AccountCharacters GetCharacters()
        {
            //For some reason I wasn't able to use the Mapper class to auto convert the json to an AccountCharacters 
            //object so had to do it manually
            //I assume it has something to do with this json is a single list [] instead of an object {}
            string json = _apiConnector.ApiCall(CharactersEndpoint);
            var characters = JsonConvert.DeserializeObject<List<string>>(json);
            return new AccountCharacters {Name = characters};;
          
        }
    }
}