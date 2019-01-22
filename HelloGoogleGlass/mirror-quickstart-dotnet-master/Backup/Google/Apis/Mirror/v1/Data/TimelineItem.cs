namespace Google.Apis.Mirror.v1.Data
{
    using Google.Apis.Requests;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class TimelineItem : IDirectResponseSchema
    {
        private IList<Attachment> _attachments;
        private string _bundleId;
        private string _canonicalUrl;
        private string _created;
        private Contact _creator;
        private string _displayTime;
        private string _etag;
        private string _html;
        private IList<string> _htmlPages;
        private string _id;
        private string _inReplyTo;
        private bool? _isBundleCover;
        private bool? _isDeleted;
        private bool? _isPinned;
        private string _kind;
        private Google.Apis.Mirror.v1.Data.Location _location;
        private IList<MenuItem> _menuItems;
        private NotificationConfig _notification;
        private long? _pinScore;
        private IList<Contact> _recipients;
        private string _selfLink;
        private string _sourceItemId;
        private string _speakableText;
        private string _text;
        private string _title;
        private string _updated;

        [JsonProperty("attachments")]
        public virtual IList<Attachment> Attachments
        {
            get
            {
                return this._attachments;
            }
            set
            {
                this._attachments = value;
            }
        }

        [JsonProperty("bundleId")]
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

        [JsonProperty("canonicalUrl")]
        public virtual string CanonicalUrl
        {
            get
            {
                return this._canonicalUrl;
            }
            set
            {
                this._canonicalUrl = value;
            }
        }

        [JsonProperty("created")]
        public virtual string Created
        {
            get
            {
                return this._created;
            }
            set
            {
                this._created = value;
            }
        }

        [JsonProperty("creator")]
        public virtual Contact Creator
        {
            get
            {
                return this._creator;
            }
            set
            {
                this._creator = value;
            }
        }

        [JsonProperty("displayTime")]
        public virtual string DisplayTime
        {
            get
            {
                return this._displayTime;
            }
            set
            {
                this._displayTime = value;
            }
        }

        [JsonProperty("etag")]
        public virtual string ETag
        {
            get
            {
                return this._etag;
            }
            set
            {
                this._etag = value;
            }
        }

        [JsonProperty("html")]
        public virtual string Html
        {
            get
            {
                return this._html;
            }
            set
            {
                this._html = value;
            }
        }

        [JsonProperty("htmlPages")]
        public virtual IList<string> HtmlPages
        {
            get
            {
                return this._htmlPages;
            }
            set
            {
                this._htmlPages = value;
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

        [JsonProperty("inReplyTo")]
        public virtual string InReplyTo
        {
            get
            {
                return this._inReplyTo;
            }
            set
            {
                this._inReplyTo = value;
            }
        }

        [JsonProperty("isBundleCover")]
        public virtual bool? IsBundleCover
        {
            get
            {
                return this._isBundleCover;
            }
            set
            {
                this._isBundleCover = value;
            }
        }

        [JsonProperty("isDeleted")]
        public virtual bool? IsDeleted
        {
            get
            {
                return this._isDeleted;
            }
            set
            {
                this._isDeleted = value;
            }
        }

        [JsonProperty("isPinned")]
        public virtual bool? IsPinned
        {
            get
            {
                return this._isPinned;
            }
            set
            {
                this._isPinned = value;
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

        [JsonProperty("location")]
        public virtual Google.Apis.Mirror.v1.Data.Location Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }

        [JsonProperty("menuItems")]
        public virtual IList<MenuItem> MenuItems
        {
            get
            {
                return this._menuItems;
            }
            set
            {
                this._menuItems = value;
            }
        }

        [JsonProperty("notification")]
        public virtual NotificationConfig Notification
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

        [JsonProperty("pinScore")]
        public virtual long? PinScore
        {
            get
            {
                return this._pinScore;
            }
            set
            {
                this._pinScore = value;
            }
        }

        [JsonProperty("recipients")]
        public virtual IList<Contact> Recipients
        {
            get
            {
                return this._recipients;
            }
            set
            {
                this._recipients = value;
            }
        }

        [JsonProperty("selfLink")]
        public virtual string SelfLink
        {
            get
            {
                return this._selfLink;
            }
            set
            {
                this._selfLink = value;
            }
        }

        [JsonProperty("sourceItemId")]
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

        [JsonProperty("speakableText")]
        public virtual string SpeakableText
        {
            get
            {
                return this._speakableText;
            }
            set
            {
                this._speakableText = value;
            }
        }

        [JsonProperty("text")]
        public virtual string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        [JsonProperty("title")]
        public virtual string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
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
    }
}

