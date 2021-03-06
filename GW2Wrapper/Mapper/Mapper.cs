﻿using System;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace GW2Wrapper.Mapper
{
    public class Mapper : IMapper
    {
        public T MapTop<T>(string toMap)
        {
            
            try
            {
                var options = new JsonSerializerOptions
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true,
                };
                var output = JsonConvert.DeserializeObject<T>(toMap);
                //T output = JsonSerializer.Deserialize<T>(toMap, options);
                return output;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
            
        }
    }
}