namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;

    public class Attachment : IDirectResponseSchema
    {
        private string _contentType;
        private string _contentUrl;
        private string _ETag;
        private string _id;
        private bool? _isProcessingContent;

        [JsonProperty("contentType")]
        public virtual string ContentType
        {
            get
            {
                return this._contentType;
            }
            set
            {
                this._contentType = value;
            }
        }

        [JsonProperty("contentUrl")]
        public virtual string ContentUrl
        {
            get
            {
                return this._contentUrl;
            }
            set
            {
                this._contentUrl = value;
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

        [JsonProperty("isProcessingContent")]
        public virtual bool? IsProcessingContent
        {
            get
            {
                return this._isProcessingContent;
            }
            set
            {
                this._isProcessingContent = value;
            }
        }
    }
}

