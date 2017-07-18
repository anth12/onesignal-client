using System;
using OneSignal.Client.Attributes;

namespace OneSignal.Client.V1.Endpoints.Device
{
    public class ViewDevicesRequest
    {
        /// <summary>
        /// REQUIRED The app ID that you want to view devices from
        /// </summary>
        [Key("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// How many devices to return. Max is 300. Default is 300
        /// </summary>
        [Key("limit")]
        public int Limit { get; set; } = 300;

        /// <summary>
        /// Result offset. Default is 0. Results are sorted by id;
        /// </summary>
        [Key("offset")]
        public int offset { get; set; }

    }
}
