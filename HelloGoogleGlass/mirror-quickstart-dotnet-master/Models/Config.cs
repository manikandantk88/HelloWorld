/*
 * Copyright (c) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace MirrorQuickstart.Models
{
    /// <summary>
    /// Static class holding OAuth 2.0 configuration constants.
    /// </summary>
    internal static class Config
    {
        /// The OAuth2.0 Client ID of your project.
        /// </summary>
        //public static readonly string CLIENT_ID = "1027977581290.apps.googleusercontent.com";

        public static readonly string CLIENT_ID = "488950004248-tjl4s0inkg30j6n7kbaj2quk19rniv79.apps.googleusercontent.com";

        /// <summary>
        /// The OAuth2.0 Client secret of your project.
        /// </summary>
        //public static readonly string CLIENT_SECRET = "08_lgaj9b9v7ZAQRfv0kGYe8";

        public static readonly string CLIENT_SECRET = "5sUWHBl8YbhaQpCdm6bTEVa8";

        /// <summary>
        /// The OAuth2.0 scopes required by your project.
        /// </summary>
        public static readonly string[] SCOPES = new String[]
        {
            "https://www.googleapis.com/auth/userinfo.email",
            "https://www.googleapis.com/auth/glass.timeline",
            "https://www.googleapis.com/auth/glass.location",
            "https://www.googleapis.com/auth/userinfo.profile"
        };



        /// <summary>
        /// The Redirect URI of your project.
        /// </summary>
        public static readonly string REDIRECT_URI = "http://localhost:65320/oauth2callback";
    }
}