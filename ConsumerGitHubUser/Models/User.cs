using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ConsumerGitHubUser.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id{get;set;}
        [JsonPropertyName("nome")]
        public string Name {get; set;}
        [JsonPropertyName("empresa")]
        public string Empresa{get;set;}
        [JsonPropertyName("localizacao")]
        public string Localizacao{get;set;}
        [JsonPropertyName("login")]
        public string Login{get;set;}
    }
}