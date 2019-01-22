using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloOAuthMVC.GoogleApi
{
    /// <summary>
    /// Static class holding OAuth 2.0 configuration constants.
    /// </summary>
    internal static class Config
    {
        /// <summary>
        /// The OAuth2.0 Client ID of your project.
        /// </summary>
        public static readonly string CLIENT_ID = "350521374598-r6iupunvot5k8f7q380h15uijfr98m45.apps.googleusercontent.com";

        /// <summary>
        /// The OAuth2.0 Client secret of your project.
        /// </summary>
        public static readonly string CLIENT_SECRET = "6p2tnV9Y9uGshdsGIbRK_SBb";

        /// <summary>
        /// The OAuth2.0 scopes required by your project.
        /// </summary>
        public static readonly string[] SCOPES = new String[]
        {
            "https://www.googleapis.com/auth/userinfo.email",
            "https://www.googleapis.com/auth/userinfo.profile",
            "https://www.googleapis.com/auth/plus.me"
        };
        
        /// <summary>
        /// The Redirect URI of your project.
        /// </summary>
        public static readonly string REDIRECT_URI = "http://localhost:53758/Auth/OAuth2Callback";
    }
}