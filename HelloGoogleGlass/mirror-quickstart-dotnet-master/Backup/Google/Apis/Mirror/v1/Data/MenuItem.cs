namespace Google.Apis.Mirror.v1.Data
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class MenuItem
    {
        private string _action;
        private string _id;
        private bool? _removeWhenSelected;
        private IList<MenuValue> _values;

        [JsonProperty("action")]
        public virtual string Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
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

        [JsonProperty("removeWhenSelected")]
        public virtual bool? RemoveWhenSelected
        {
            get
            {
                return this._removeWhenSelected;
            }
            set
            {
                this._removeWhenSelected = value;
            }
        }

        [JsonProperty("values")]
        public virtual IList<MenuValue> Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }
    }
}

