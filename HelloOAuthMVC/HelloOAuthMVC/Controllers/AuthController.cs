using HelloOAuthMVC.GoogleApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HelloOAuthMVC.Controllers
{
    public class AuthController : Controller
    {
        private const string URL_OAUTH2 = "https://accounts.google.com/o/oauth2/v2/auth";
        private const string URL_GET_TOKEN = "https://www.googleapis.com/oauth2/v4/token";
        private const string URL_TOKEN_INFO = "https://www.googleapis.com/oauth2/v3/tokeninfo";

        // GET: Auth
        public ActionResult SignIn()
        {
            //Step1: Set authorization parameters
            var uriBuilder = new UriBuilder(URL_OAUTH2);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            var scopes = string.Join(" ", Config.SCOPES);
            query.Set("scope", scopes);
            query.Set("access_type", "offline");
            query.Set("state", GetState());
            query.Set("redirect_uri", Config.REDIRECT_URI);
            query.Set("response_type", "code");
            query.Set("client_id", Config.CLIENT_ID);
            uriBuilder.Query = query.ToString();

            //Step2: Redirect to consent screen
            return Redirect(uriBuilder.ToString());
        }
        

        // GET: /oauth2callback
        public async Task<ActionResult> OAuth2Callback(String code)
        {
            //Step 5: Exchange authorization code for refresh and access tokens
            var parameters = new List<string>();
            parameters.Add("code=" + code);
            parameters.Add("client_id=" + Config.CLIENT_ID);
            parameters.Add("client_secret=" + Config.CLIENT_SECRET);
            parameters.Add("redirect_uri=" + Config.REDIRECT_URI);
            parameters.Add("grant_type=authorization_code");

            var cts = new CancellationTokenSource();
            cts.CancelAfter(TimeSpan.FromSeconds(10).Milliseconds);
            var ct = cts.Token;

            var httpClientHandler = new HttpClientHandler();
            var httpClient = new HttpClient(httpClientHandler);
            var content = new StringContent(string.Join("&", parameters));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            var response = await httpClient.PostAsync(URL_GET_TOKEN, content);
            if (true == response.IsSuccessStatusCode)
            {
                var jsonTokenInfo = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine("Token Info:{0}", jsonTokenInfo);
                var tokenInfo = JsonConvert.DeserializeObject<UserTokenInfo>(jsonTokenInfo);

                var uriBuilder = new UriBuilder("https://www.googleapis.com/oauth2/v1/userinfo");
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                query.Set("access_token", tokenInfo.AccessToken);
                uriBuilder.Query = query.ToString();
                var url = uriBuilder.ToString();
                System.Diagnostics.Debug.WriteLine("Sending Request:{0}", url);
                var jsonUserInfo = await httpClient.GetStringAsync(url);
                System.Diagnostics.Debug.WriteLine("User Info:{0}", jsonUserInfo);
            }
            else
            {

            }
            return Redirect(Url.Action("Index", "Home"));
        }

        private string GetState()
        {
            return "ThisIsHelloMVCOAuthProject";
        }


    }
}