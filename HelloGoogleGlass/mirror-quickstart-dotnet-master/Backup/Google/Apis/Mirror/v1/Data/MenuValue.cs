namespace Google.Apis.Mirror.v1.Data
{
    using Newtonsoft.Json;
    using System;

    public class MenuValue
    {
        private string _displayName;
        private string _iconUrl;
        private string _state;

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

        [JsonProperty("iconUrl")]
        public virtual string IconUrl
        {
            get
            {
                return this._iconUrl;
            }
            set
            {
                this._iconUrl = value;
            }
        }

        [JsonProperty("state")]
        public virtual string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
    }
}

