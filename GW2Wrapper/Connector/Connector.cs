using System;
using System.Net;
using System.Net.Http;

namespace GW2Wrapper.Connector
{
    public class Connector : IConnector
    {
        private readonly string _apiKey;
        private readonly HttpClient _client = new HttpClient();
        private const string DefaultUri = @"https://api.guildwars2.com/";

        
        public Connector(string apiKey)
        {
            _apiKey = apiKey;
        }
        
        public Connector(){}

        public string ApiCall(string endPoint)
        {
            _client.DefaultRequestHeaders.Clear();

            if (_apiKey != null)
            {
                _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }
            
            string requestUri = $@"{DefaultUri}{endPoint}";
            var stringTask = _client.GetAsync(requestUri);
            stringTask.Wait();
            var result = stringTask.Result;
            return result.Content.ReadAsStringAsync().Result;
        }
    }
}