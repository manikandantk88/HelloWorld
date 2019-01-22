namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Subscription : IDirectResponseSchema
    {
        private string _callbackUrl;
        private string _collection;
        private string _ETag;
        private string _id;
        private string _kind;
        private Google.Apis.Mirror.v1.Data.Notification _notification;
        private IList<string> _operation;
        private string _updated;
        private string _userToken;
        private string _verifyToken;

        [JsonProperty("callbackUrl")]
        public virtual string CallbackUrl
        {
            get
            {
                return this._callbackUrl;
            }
            set
            {
                this._callbackUrl = value;
            }
        }

        [JsonProperty("collection")]
        public virtual string Collection
        {
            get
            {
                return this._collection;
            }
            set
            {
                this._collection = value;
            }
        }

        public virtual string ETag
        {
            get
            {
                return this._ETag;
            }
            set
            {
                this._ETag = value;
            }
        }

        [JsonProperty("id")]
        public virtual string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [JsonProperty("kind")]
        public virtual string Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }

        [JsonProperty("notification")]
        public virtual Google.Apis.Mirror.v1.Data.Notification Notification
        {
            get
            {
                return this._notification;
            }
            set
            {
                this._notification = value;
            }
        }

        [JsonProperty("operation")]
        public virtual IList<string> Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }

        [JsonProperty("updated")]
        public virtual string Updated
        {
            get
            {
                return this._updated;
            }
            set
            {
                this._updated = value;
            }
        }

        [JsonProperty("userToken")]
        public virtual string UserToken
        {
            get
            {
                return this._userToken;
            }
            set
            {
                this._userToken = value;
            }
        }

        [JsonProperty("verifyToken")]
        public virtual string VerifyToken
        {
            get
            {
                return this._verifyToken;
            }
            set
            {
                this._verifyToken = value;
            }
        }
    }
}

