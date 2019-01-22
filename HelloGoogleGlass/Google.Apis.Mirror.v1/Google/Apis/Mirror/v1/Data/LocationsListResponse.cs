namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class LocationsListResponse : IDirectResponseSchema
    {
        private string _ETag;
        private IList<Location> _items;
        private string _kind;

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
        public virtual IList<Location> Items
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
    }
}

