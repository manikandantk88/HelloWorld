namespace Google.Apis.Mirror.v1.Data
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Notification
    {
        private string _collection;
        private string _itemId;
        private string _operation;
        private IList<UserAction> _userActions;
        private string _userToken;
        private string _verifyToken;

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

        [JsonProperty("itemId")]
        public virtual string ItemId
        {
            get
            {
                return this._itemId;
            }
            set
            {
                this._itemId = value;
            }
        }

        [JsonProperty("operation")]
        public virtual string Operation
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

        [JsonProperty("userActions")]
        public virtual IList<UserAction> UserActions
        {
            get
            {
                return this._userActions;
            }
            set
            {
                this._userActions = value;
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

