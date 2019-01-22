namespace Google.Apis.Mirror.v1.Data
{
    using Newtonsoft.Json;
    using System;

    public class NotificationConfig
    {
        private string _deliveryTime;
        private string _level;

        [JsonProperty("deliveryTime")]
        public virtual string DeliveryTime
        {
            get
            {
                return this._deliveryTime;
            }
            set
            {
                this._deliveryTime = value;
            }
        }

        [JsonProperty("level")]
        public virtual string Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
    }
}

