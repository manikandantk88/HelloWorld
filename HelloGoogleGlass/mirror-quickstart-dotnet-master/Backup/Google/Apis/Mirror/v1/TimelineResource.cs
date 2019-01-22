namespace Google.Apis.Mirror.v1
{
    using Google.Apis.Authentication;
    using Google.Apis.Mirror.v1.Data;
    using Google.Apis.Requests;
    using Google.Apis.Services;
    using Google.Apis.Upload;
    using Google.Apis.Util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    public class TimelineResource
    {
        private AttachmentsResource _attachments;
        private IAuthenticator authenticator;
        private const string Resource = "timeline";
        private MirrorService service;

        public TimelineResource(MirrorService service, IAuthenticator authenticator)
        {
            this.service = service;
            this.authenticator = authenticator;
            this._attachments = new AttachmentsResource(service, authenticator);
        }

        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(this.service, id);
        }

        public virtual GetRequest Get(string id)
        {
            return new GetRequest(this.service, id);
        }

        public virtual InsertRequest Insert(TimelineItem body)
        {
            return new InsertRequest(this.service, body);
        }

        public virtual InsertMediaUpload Insert(TimelineItem body, Stream stream, string contentType)
        {
            return new InsertMediaUpload(this.service, body, stream, contentType);
        }

        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        public virtual PatchRequest Patch(TimelineItem body, string id)
        {
            return new PatchRequest(this.service, body, id);
        }

        public virtual UpdateRequest Update(TimelineItem body, string id)
        {
            return new UpdateRequest(this.service, body, id);
        }

        public virtual UpdateMediaUpload Update(TimelineItem body, string id, Stream stream, string contentType)
        {
            return new UpdateMediaUpload(this.service, body, id, stream, contentType);
        }

        public virtual AttachmentsResource Attachments
        {
            get
            {
                return this._attachments;
            }
        }

        public class AttachmentsResource
        {
            private IAuthenticator authenticator;
            private const string Resource = "timeline.attachments";
            private MirrorService service;

            public AttachmentsResource(MirrorService service, IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            public virtual DeleteRequest Delete(string itemId, string attachmentId)
            {
                return new DeleteRequest(this.service, itemId, attachmentId);
            }

            public virtual GetRequest Get(string itemId, string attachmentId)
            {
                return new GetRequest(this.service, itemId, attachmentId);
            }

            public virtual InsertRequest Insert(string itemId)
            {
                return new InsertRequest(this.service, itemId);
            }

            public virtual InsertMediaUpload Insert(string itemId, Stream stream, string contentType)
            {
                return new InsertMediaUpload(this.service, itemId, stream, contentType);
            }

            public virtual ListRequest List(string itemId)
            {
                return new ListRequest(this.service, itemId);
            }

            public class DeleteRequest : ClientServiceRequest<string>
            {
                private string _alt;
                private string _attachmentId;
                private string _fields;
                private string _itemId;
                private string _oauth_token;
                private bool? _prettyPrint;
                private string _quotaUser;
                private string _userIp;

                public DeleteRequest(IClientService service, string itemId, string attachmentId) : base(service)
                {
                    this._itemId = itemId;
                    this._attachmentId = attachmentId;
                    this.InitParameters();
                }

                private void InitParameters()
                {
                    Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                    dictionaryToWrap.Add("itemId", Utilities.CreateRuntimeParameter("itemId", true, "path", null, null, new string[0]));
                    dictionaryToWrap.Add("attachmentId", Utilities.CreateRuntimeParameter("attachmentId", true, "path", null, null, new string[0]));
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

                [RequestParameter("attachmentId", RequestParameterType.Path)]
                public virtual string AttachmentId
                {
                    get
                    {
                        return this._attachmentId;
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

                [RequestParameter("itemId", RequestParameterType.Path)]
                public virtual string ItemId
                {
                    get
                    {
                        return this._itemId;
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
                        return "timeline.attachments";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "timeline/{itemId}/attachments/{attachmentId}";
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

            public class GetRequest : ClientServiceRequest<Attachment>
            {
                private string _alt;
                private string _attachmentId;
                private string _fields;
                private string _itemId;
                private string _oauth_token;
                private bool? _prettyPrint;
                private string _quotaUser;
                private string _userIp;

                public GetRequest(IClientService service, string itemId, string attachmentId) : base(service)
                {
                    this._itemId = itemId;
                    this._attachmentId = attachmentId;
                    this.InitParameters();
                }

                private void InitParameters()
                {
                    Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                    dictionaryToWrap.Add("itemId", Utilities.CreateRuntimeParameter("itemId", true, "path", null, null, new string[0]));
                    dictionaryToWrap.Add("attachmentId", Utilities.CreateRuntimeParameter("attachmentId", true, "path", null, null, new string[0]));
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

                [RequestParameter("attachmentId", RequestParameterType.Path)]
                public virtual string AttachmentId
                {
                    get
                    {
                        return this._attachmentId;
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

                [RequestParameter("itemId", RequestParameterType.Path)]
                public virtual string ItemId
                {
                    get
                    {
                        return this._itemId;
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
                        return "timeline.attachments";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "timeline/{itemId}/attachments/{attachmentId}";
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

            public class InsertMediaUpload : ResumableUpload<string, Attachment>
            {
                private string _alt;
                private string _fields;
                private string _itemId;
                private string _oauth_token;
                private bool? _prettyPrint;
                private string _quotaUser;
                private string _userIp;

                public InsertMediaUpload(IClientService service, string itemId, Stream stream, string contentType) : base(service.BaseUri, "/upload/mirror/v1/timeline/{itemId}/attachments", "POST", stream, contentType)
                {
                    base.Authenticator = service.Authenticator;
                    this._itemId = itemId;
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

                [RequestParameter("itemId", RequestParameterType.Path)]
                public virtual string ItemId
                {
                    get
                    {
                        return this._itemId;
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

            public class InsertRequest : ClientServiceRequest<Attachment>
            {
                private string _alt;
                private string _fields;
                private string _itemId;
                private string _oauth_token;
                private bool? _prettyPrint;
                private string _quotaUser;
                private string _userIp;

                public InsertRequest(IClientService service, string itemId) : base(service)
                {
                    this._itemId = itemId;
                    this.InitParameters();
                }

                private void InitParameters()
                {
                    Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                    dictionaryToWrap.Add("itemId", Utilities.CreateRuntimeParameter("itemId", true, "path", null, null, new string[0]));
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
                        return "POST";
                    }
                }

                [RequestParameter("itemId", RequestParameterType.Path)]
                public virtual string ItemId
                {
                    get
                    {
                        return this._itemId;
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
                        return "timeline.attachments";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "timeline/{itemId}/attachments";
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

            public class ListRequest : ClientServiceRequest<AttachmentsListResponse>
            {
                private string _alt;
                private string _fields;
                private string _itemId;
                private string _oauth_token;
                private bool? _prettyPrint;
                private string _quotaUser;
                private string _userIp;

                public ListRequest(IClientService service, string itemId) : base(service)
                {
                    this._itemId = itemId;
                    this.InitParameters();
                }

                private void InitParameters()
                {
                    Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                    dictionaryToWrap.Add("itemId", Utilities.CreateRuntimeParameter("itemId", true, "path", null, null, new string[0]));
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

                [RequestParameter("itemId", RequestParameterType.Path)]
                public virtual string ItemId
                {
                    get
                    {
                        return this._itemId;
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
                        return "timeline.attachments";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "timeline/{itemId}/attachments";
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline/{id}";
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

        public class GetRequest : ClientServiceRequest<TimelineItem>
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline/{id}";
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

        public class InsertMediaUpload : ResumableUpload<TimelineItem, TimelineItem>
        {
            private string _alt;
            private string _fields;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public InsertMediaUpload(IClientService service, TimelineItem body, Stream stream, string contentType) : base(service.BaseUri, "/upload/mirror/v1/timeline", "POST", stream, contentType)
            {
                base.Body = body;
                base.Authenticator = service.Authenticator;
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

        public class InsertRequest : ClientServiceRequest<TimelineItem>
        {
            private string _alt;
            private TimelineItem _Body;
            private string _fields;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public InsertRequest(IClientService service, TimelineItem body) : base(service)
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

            public virtual TimelineItem Body
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline";
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

        public class ListRequest : ClientServiceRequest<TimelineListResponse>
        {
            private string _alt;
            private string _bundleId;
            private string _fields;
            private bool? _includeDeleted;
            private long? _maxResults;
            private string _oauth_token;
            private Google.Apis.Mirror.v1.TimelineResource.OrderBy? _orderBy;
            private string _pageToken;
            private bool? _pinnedOnly;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _sourceItemId;
            private string _userIp;

            public ListRequest(IClientService service) : base(service)
            {
                this.InitParameters();
            }

            private void InitParameters()
            {
                Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
                string[] enumValues = new string[] { "displayTime", "writeTime" };
                dictionaryToWrap.Add("orderBy", Utilities.CreateRuntimeParameter("orderBy", false, "query", null, null, enumValues));
                dictionaryToWrap.Add("includeDeleted", Utilities.CreateRuntimeParameter("includeDeleted", false, "query", null, null, new string[0]));
                dictionaryToWrap.Add("maxResults", Utilities.CreateRuntimeParameter("maxResults", false, "query", null, null, new string[0]));
                dictionaryToWrap.Add("pageToken", Utilities.CreateRuntimeParameter("pageToken", false, "query", null, null, new string[0]));
                dictionaryToWrap.Add("sourceItemId", Utilities.CreateRuntimeParameter("sourceItemId", false, "query", null, null, new string[0]));
                dictionaryToWrap.Add("pinnedOnly", Utilities.CreateRuntimeParameter("pinnedOnly", false, "query", null, null, new string[0]));
                dictionaryToWrap.Add("bundleId", Utilities.CreateRuntimeParameter("bundleId", false, "query", null, null, new string[0]));
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

            [RequestParameter("bundleId", RequestParameterType.Query)]
            public virtual string BundleId
            {
                get
                {
                    return this._bundleId;
                }
                set
                {
                    this._bundleId = value;
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

            [RequestParameter("includeDeleted", RequestParameterType.Query)]
            public virtual bool? IncludeDeleted
            {
                get
                {
                    return this._includeDeleted;
                }
                set
                {
                    this._includeDeleted = value;
                }
            }

            [RequestParameter("maxResults", RequestParameterType.Query)]
            public virtual long? MaxResults
            {
                get
                {
                    return this._maxResults;
                }
                set
                {
                    this._maxResults = value;
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

            [RequestParameter("orderBy", RequestParameterType.Query)]
            public virtual Google.Apis.Mirror.v1.TimelineResource.OrderBy? OrderBy
            {
                get
                {
                    return this._orderBy;
                }
                set
                {
                    this._orderBy = value;
                }
            }

            [RequestParameter("pageToken", RequestParameterType.Query)]
            public virtual string PageToken
            {
                get
                {
                    return this._pageToken;
                }
                set
                {
                    this._pageToken = value;
                }
            }

            [RequestParameter("pinnedOnly", RequestParameterType.Query)]
            public virtual bool? PinnedOnly
            {
                get
                {
                    return this._pinnedOnly;
                }
                set
                {
                    this._pinnedOnly = value;
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline";
                }
            }

            [RequestParameter("sourceItemId", RequestParameterType.Query)]
            public virtual string SourceItemId
            {
                get
                {
                    return this._sourceItemId;
                }
                set
                {
                    this._sourceItemId = value;
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

        [TypeConverter(typeof(EnumStringValueTypeConverter))]
        public enum OrderBy
        {
            [StringValue("displayTime")]
            DisplayTime = 0,
            [StringValue("writeTime")]
            WriteTime = 1
        }

        public class PatchRequest : ClientServiceRequest<TimelineItem>
        {
            private string _alt;
            private TimelineItem _Body;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public PatchRequest(IClientService service, TimelineItem body, string id) : base(service)
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

            public virtual TimelineItem Body
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline/{id}";
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

        public class UpdateMediaUpload : ResumableUpload<TimelineItem, TimelineItem>
        {
            private string _alt;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public UpdateMediaUpload(IClientService service, TimelineItem body, string id, Stream stream, string contentType) : base(service.BaseUri, "/upload/mirror/v1/timeline/{id}", "PUT", stream, contentType)
            {
                base.Body = body;
                base.Authenticator = service.Authenticator;
                this._id = id;
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

            [RequestParameter("id", RequestParameterType.Path)]
            public virtual string Id
            {
                get
                {
                    return this._id;
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

        public class UpdateRequest : ClientServiceRequest<TimelineItem>
        {
            private string _alt;
            private TimelineItem _Body;
            private string _fields;
            private string _id;
            private string _oauth_token;
            private bool? _prettyPrint;
            private string _quotaUser;
            private string _userIp;

            public UpdateRequest(IClientService service, TimelineItem body, string id) : base(service)
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

            public virtual TimelineItem Body
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
                    return "timeline";
                }
            }

            public override string RestPath
            {
                get
                {
                    return "timeline/{id}";
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

