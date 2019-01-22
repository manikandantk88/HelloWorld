using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloOAuthMVC.GoogleApi
{
    public class UserProfileInfo
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
    }
}