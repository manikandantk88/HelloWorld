namespace Google.Apis.Mirror.v1
{
    using Google.Apis.Discovery;
    using Google.Apis.Requests;
    using Google.Apis.Services;
    using Google.Apis.Util;
    using System;
    using System.Collections.Generic;

    public class MirrorService : BaseClientService
    {
        private ContactsResource _contacts;
        private LocationsResource _locations;
        private IDictionary<string, IParameter> _serviceParameters;
        private SubscriptionsResource _subscriptions;
        private TimelineResource _timeline;
        public static DiscoveryVersion DiscoveryVersionUsed = DiscoveryVersion.Version_1_0;
        private const string Resource = "";
        public const string Version = "v1";

        public MirrorService() : this(new BaseClientService.Initializer())
        {
        }

        public MirrorService(BaseClientService.Initializer initializer) : base(initializer)
        {
            this._timeline = new TimelineResource(this, base.Authenticator);
            this._subscriptions = new SubscriptionsResource(this, base.Authenticator);
            this._locations = new LocationsResource(this, base.Authenticator);
            this._contacts = new ContactsResource(this, base.Authenticator);
            this.InitParameters();
        }

        public override IRequest CreateRequest(IClientServiceRequest serviceRequest)
        {
            IRequest request = Request.CreateRequest(this, serviceRequest);
            if (!string.IsNullOrEmpty(base.ApiKey))
            {
                request = request.WithKey(base.ApiKey);
            }
            return request.WithAuthentication(base.Authenticator);
        }

        private void InitParameters()
        {
            Dictionary<string, IParameter> dictionaryToWrap = new Dictionary<string, IParameter>();
            dictionaryToWrap.Add("prettyPrint", Utilities.CreateRuntimeParameter("prettyPrint", false, "query", "true", null, new string[0]));
            dictionaryToWrap.Add("fields", Utilities.CreateRuntimeParameter("fields", false, "query", null, null, new string[0]));
            dictionaryToWrap.Add("quotaUser", Utilities.CreateRuntimeParameter("quotaUser", false, "query", null, null, new string[0]));
            dictionaryToWrap.Add("oauth_token", Utilities.CreateRuntimeParameter("oauth_token", false, "query", null, null, new string[0]));
            dictionaryToWrap.Add("key", Utilities.CreateRuntimeParameter("key", false, "query", null, null, new string[0]));
            dictionaryToWrap.Add("userIp", Utilities.CreateRuntimeParameter("userIp", false, "query", null, null, new string[0]));
            string[] enumValues = new string[] { "json" };
            dictionaryToWrap.Add("alt", Utilities.CreateRuntimeParameter("alt", false, "query", "json", null, enumValues));
            this._serviceParameters = new ReadOnlyDictionary<string, IParameter>(dictionaryToWrap);
        }

        public override string BaseUri
        {
            get
            {
                return "https://www.googleapis.com/mirror/v1/";
            }
        }

        public virtual ContactsResource Contacts
        {
            get
            {
                return this._contacts;
            }
        }

        public override IList<string> Features
        {
            get
            {
                return new string[0];
            }
        }

        public virtual LocationsResource Locations
        {
            get
            {
                return this._locations;
            }
        }

        public override string Name
        {
            get
            {
                return "mirror";
            }
        }

        private IClientService service
        {
            get
            {
                return this;
            }
        }

        public override IDictionary<string, IParameter> ServiceParameters
        {
            get
            {
                return this._serviceParameters;
            }
        }

        public virtual SubscriptionsResource Subscriptions
        {
            get
            {
                return this._subscriptions;
            }
        }

        public virtual TimelineResource Timeline
        {
            get
            {
                return this._timeline;
            }
        }
    }
}

