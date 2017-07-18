using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal.Client.V1.Endpoints.Device
{
    public class ViewDevicesResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("players")]
        public IList<Player> Players { get; set; }
    }

    public class Player
    {

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("session_count")]
        public int SessionCount { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        [JsonProperty("device_os")]
        public string DeviceOs { get; set; }

        [JsonProperty("device_type")]
        public int DeviceType { get; set; }

        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        [JsonProperty("ad_id")]
        public object AdId { get; set; }

        [JsonProperty("tags")]
        public Dictionary<string, string> Tags { get; set; }

        [JsonProperty("last_active")]
        public int LastActive { get; set; }

        [JsonProperty("amount_spent")]
        public double AmountSpent { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("invalid_identifier")]
        public bool InvalidIdentifier { get; set; }

        [JsonProperty("badge_count")]
        public int BadgeCount { get; set; }
    }
}
