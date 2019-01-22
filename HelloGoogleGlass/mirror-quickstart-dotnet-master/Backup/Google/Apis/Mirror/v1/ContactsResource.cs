namespace Google.Apis.Mirror.v1
{
    using Google.Apis.Authentication;
    using Google.Apis.Mirror.v1.Data;
    using Google.Apis.Requests;
    using Google.Apis.Services;
    using Google.Apis.Util;
    using System;
    using System.Collections.Generic;

    public class ContactsResource
    {
        private IAuthenticator authenticator;
        private const string Resource = "contacts";
        private MirrorService service;

        public ContactsResource(MirrorService service, IAuthenticator authenticator)
        {
            this.service = service;
            this.authenticator = authenticator;
        }

        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(this.service, id);
        }

        public virtual GetRequest Get(string id)
        {
            return new GetRequest(this.service, id);
        }

        public virtual InsertRequest Insert(Contact body)
        {
            return new InsertRequest(this.service, body);
        }

        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        public virtual PatchRequest Patch(Contact body, string id)
        {
            return new PatchRequest(this.service, body, id);
        }

        public virtual UpdateRequest Update(Contact body, string id)
        {
            return new UpdateRequest(this.service, body, id);
        }

        public class DeleteRequest : ClientServiceRequest<string>
        {
            private string _alt;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public DeleteRequest(IClientService service, string id) : base(service)
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
                    return "DELETE";
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
                    return "delete";
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts/{id}";
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

        public class GetRequest : ClientServiceRequest<Contact>
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts/{id}";
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

        public class InsertRequest : ClientServiceRequest<Contact>
        {
            private string _alt;
            private Contact _Body;
            private string _fields;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public InsertRequest(IClientService service, Contact body) : base(service)
            {
                this.Body = body;
                this.InitParameters();
            }

            protected override object GetBody()
            {
                return this.Body;
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

            public virtual Contact Body
            {
                get
                {
                    return this._Body;
                }
                set
                {
                    this._Body = value;
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
                    return "POST";
                }
            }

            public override string MethodName
            {
                get
                {
                    return "insert";
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts";
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

        public class ListRequest : ClientServiceRequest<ContactsListResponse>
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts";
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

        public class PatchRequest : ClientServiceRequest<Contact>
        {
            private string _alt;
            private Contact _Body;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public PatchRequest(IClientService service, Contact body, string id) : base(service)
            {
                this.Body = body;
                this._id = id;
                this.InitParameters();
            }

            protected override object GetBody()
            {
                return this.Body;
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

            public virtual Contact Body
            {
                get
                {
                    return this._Body;
                }
                set
                {
                    this._Body = value;
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
                    return "PATCH";
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
                    return "patch";
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts/{id}";
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

        public class UpdateRequest : ClientServiceRequest<Contact>
        {
            private string _alt;
            private Contact _Body;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public UpdateRequest(IClientService service, Contact body, string id) : base(service)
            {
                this.Body = body;
                this._id = id;
                this.InitParameters();
            }

            protected override object GetBody()
            {
                return this.Body;
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

            public virtual Contact Body
            {
                get
                {
                    return this._Body;
                }
                set
                {
                    this._Body = value;
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
                    return "PUT";
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
                    return "update";
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
                    return "contacts";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "contacts/{id}";
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

