using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloOAuthMVC.GoogleApi
{
    public class UserTokenInfo
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("expires_in")]
        public int ExpirtyTimeInSeconds { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}