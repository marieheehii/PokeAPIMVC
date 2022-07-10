using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

    public class PokemonViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url {get; set;}
        [JsonPropertyName("height")]
        public string Height {get; set;}
        [JsonPropertyName("weight")]
        public string Weight {get; set;}
        [JsonPropertyName("type")]
        public string Type {get; set;}
        
        public string Id
        {
            get{
                return Url
                .Split("/", StringSplitOptions.RemoveEmptyEntries)
                .LastOrDefault();
            }
        }
    }
