using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


    public class ResultsViewModel<TResult>
    {
        [JsonPropertyName("count")]
        public int Count {get; set;}
        [JsonPropertyName("next")]
        public string Next {get; set;}
        [JsonPropertyName("previous")]
        public string Previous {get; set;}
       [ JsonPropertyName("results")]
       public IEnumerable<TResult> Results {get; set;}
        public string NextPageNum => Next?.Split("?page=").LastOrDefault();
        public string PrevPageNum => Previous?.Split("?page=").LastOrDefault();
    }
    
