namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;

    public class Location : IDirectResponseSchema
    {
        private double? _accuracy;
        private string _address;
        private string _displayName;
        private string _ETag;
        private string _id;
        private string _kind;
        private double? _latitude;
        private double? _longitude;
        private string _timestamp;

        [JsonProperty("accuracy")]
        public virtual double? Accuracy
        {
            get
            {
                return this._accuracy;
            }
            set
            {
                this._accuracy = value;
            }
        }

        [JsonProperty("address")]
        public virtual string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
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

        [JsonProperty("latitude")]
        public virtual double? Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                this._latitude = value;
            }
        }

        [JsonProperty("longitude")]
        public virtual double? Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                this._longitude = value;
            }
        }

        [JsonProperty("timestamp")]
        public virtual string Timestamp
        {
            get
            {
                return this._timestamp;
            }
            set
            {
                this._timestamp = value;
            }
        }
    }
}

