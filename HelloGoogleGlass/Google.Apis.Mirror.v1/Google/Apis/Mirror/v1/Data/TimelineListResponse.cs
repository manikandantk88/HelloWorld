namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class TimelineListResponse : IDirectResponseSchema
    {
        private string _ETag;
        private IList<TimelineItem> _items;
        private string _kind;
        private string _nextPageToken;

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

        [JsonProperty("items")]
        public virtual IList<TimelineItem> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
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

        [JsonProperty("nextPageToken")]
        public virtual string NextPageToken
        {
            get
            {
                return this._nextPageToken;
            }
            set
            {
                this._nextPageToken = value;
            }
        }
    }
}

