namespace Google.Apis.Mirror.v1.Data
{
    using Newtonsoft.Json;
    using System;

    public class UserAction
    {
        private string _payload;
        private string _type;

        [JsonProperty("payload")]
        public virtual string Payload
        {
            get
            {
                return this._payload;
            }
            set
            {
                this._payload = value;
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

