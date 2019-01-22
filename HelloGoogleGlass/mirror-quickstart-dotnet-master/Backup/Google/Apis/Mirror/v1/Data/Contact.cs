namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Contact : IDirectResponseSchema
    {
        private IList<string> _acceptTypes;
        private string _displayName;
        private string _ETag;
        private string _id;
        private IList<string> _imageUrls;
        private string _kind;
        private string _phoneNumber;
        private long? _priority;
        private string _source;
        private string _type;

        [JsonProperty("acceptTypes")]
        public virtual IList<string> AcceptTypes
        {
            get
            {
                return this._acceptTypes;
            }
            set
            {
                this._acceptTypes = value;
            }
        }

        [JsonProperty("displayName")]
        public virtual string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
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

        [JsonProperty("imageUrls")]
        public virtual IList<string> ImageUrls
        {
            get
            {
                return this._imageUrls;
            }
            set
            {
                this._imageUrls = value;
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

        [JsonProperty("phoneNumber")]
        public virtual string PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }

        [JsonProperty("priority")]
        public virtual long? Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                this._priority = value;
            }
        }

        [JsonProperty("source")]
        public virtual string Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }

        [JsonProperty("type")]
        public virtual string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}

