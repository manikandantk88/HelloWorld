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
        public static readonly string CLIENT_ID = "488950004248-tjl4s0inkg30j6n7kbaj2quk19rniv79.apps.googleusercontent.com";

        /// <summary>
        /// The OAuth2.0 Client secret of your project.
        /// </summary>
        public static readonly string CLIENT_SECRET = "5sUWHBl8YbhaQpCdm6bTEVa8";

        /// <summary>
        /// The OAuth2.0 scopes required by your project.
        /// </summary>
        public static readonly string[] SCOPES = new String[]
        {
            "https://www.googleapis.com/auth/userinfo.email",
            "https://www.googleapis.com/auth/userinfo.profile"
        };
        
        /// <summary>
        /// The Redirect URI of your project.
        /// </summary>
        public static readonly string REDIRECT_URI = "http://localhost:65320/oauth2callback";
    }
}