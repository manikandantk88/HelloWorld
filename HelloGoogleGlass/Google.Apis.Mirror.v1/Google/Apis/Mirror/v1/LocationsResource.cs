namespace Google.Apis.Mirror.v1
{
    using Google.Apis.Authentication;
    using Google.Apis.Requests;
    using Google.Apis.Services;
    using Google.Apis.Util;
    using System;
    using System.Collections.Generic;
    using Google.Apis.Mirror.v1.Data;
    using Google.Apis.Discovery;

    public class LocationsResource
    {
        private IAuthenticator authenticator;
        private const string Resource = "locations";
        private MirrorService service;

        public LocationsResource(MirrorService service, IAuthenticator authenticator)
        {
            this.service = service;
            this.authenticator = authenticator;
        }

        public virtual GetRequest Get(string id)
        {
            return new GetRequest(this.service, id);
        }

        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        public class GetRequest : ClientServiceRequest<Location>
        {
            private string _alt;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public GetRequest(IClientService service, string id) : base(service)
            {
                this._id = id;
                this.InitParameters();
            }

            private void InitParameters()
            {
                Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                dictionaryToWrap.Add("id", Utilities.CreateRuntimeParameter("id", true, "path", null, null, new string[0]));
                base._requestParameters = new ReadOnlyDictionary<string, IParameter>(dictionaryToWrap);
            }

            [RequestParameter("alt", RequestParameterType.Query)]
            public virtual string Alt
            {
                get
                {
                    return this._alt;
                }
                set
                {
                    this._alt = value;
                }
            }

            [RequestParameter("fields", RequestParameterType.Query)]
            public virtual string Fields
            {
                get
                {
                    return this._fields;
                }
                set
                {
                    this._fields = value;
                }
            }

            public override string HttpMethod
            {
                get
                {
                    return "GET";
                }
            }

            [RequestParameter("id", RequestParameterType.Path)]
            public virtual string Id
            {
                get
                {
                    return this._id;
                }
            }

            public override string MethodName
            {
                get
                {
                    return "get";
                }
            }

            [RequestParameter("oauth_token", RequestParameterType.Query)]
            public virtual string Oauth_token
            {
                get
                {
                    return this._oauth_token;
                }
                set
                {
                    this._oauth_token = value;
                }
            }

            [RequestParameter("prettyPrint", RequestParameterType.Query)]
            public virtual bool? PrettyPrint
            {
                get
                {
                    return this._prettyPrint;
                }
                set
                {
                    this._prettyPrint = value;
                }
            }

            [RequestParameter("quotaUser", RequestParameterType.Query)]
            public virtual string QuotaUser
            {
                get
                {
                    return this._quotaUser;
                }
                set
                {
                    this._quotaUser = value;
                }
            }

            public override string ResourcePath
            {
                get
                {
                    return "locations";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "locations/{id}";
                }
            }

            [RequestParameter("userIp", RequestParameterType.Query)]
            public virtual string UserIp
            {
                get
                {
                    return this._userIp;
                }
                set
                {
                    this._userIp = value;
                }
            }
        }

        public class ListRequest : ClientServiceRequest<LocationsListResponse>
        {
            private string _alt;
            private string _fields;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public ListRequest(IClientService service) : base(service)
            {
                this.InitParameters();
            }

            private void InitParameters()
            {
                Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                base._requestParameters = new ReadOnlyDictionary<string, IParameter>(dictionaryToWrap);
            }

            [RequestParameter("alt", RequestParameterType.Query)]
            public virtual string Alt
            {
                get
                {
                    return this._alt;
                }
                set
                {
                    this._alt = value;
                }
            }

            [RequestParameter("fields", RequestParameterType.Query)]
            public virtual string Fields
            {
                get
                {
                    return this._fields;
                }
                set
                {
                    this._fields = value;
                }
            }

            public override string HttpMethod
            {
                get
                {
                    return "GET";
                }
            }

            public override string MethodName
            {
                get
                {
                    return "list";
                }
            }

            [RequestParameter("oauth_token", RequestParameterType.Query)]
            public virtual string Oauth_token
            {
                get
                {
                    return this._oauth_token;
                }
                set
                {
                    this._oauth_token = value;
                }
            }

            [RequestParameter("prettyPrint", RequestParameterType.Query)]
            public virtual bool? PrettyPrint
            {
                get
                {
                    return this._prettyPrint;
                }
                set
                {
                    this._prettyPrint = value;
                }
            }

            [RequestParameter("quotaUser", RequestParameterType.Query)]
            public virtual string QuotaUser
            {
                get
                {
                    return this._quotaUser;
                }
                set
                {
                    this._quotaUser = value;
                }
            }

            public override string ResourcePath
            {
                get
                {
                    return "locations";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "locations";
                }
            }

            [RequestParameter("userIp", RequestParameterType.Query)]
            public virtual string UserIp
            {
                get
                {
                    return this._userIp;
                }
                set
                {
                    this._userIp = value;
                }
            }
        }
    }
}

