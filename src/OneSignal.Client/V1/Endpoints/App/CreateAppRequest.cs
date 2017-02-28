using System;
using Newtonsoft.Json;

namespace OneSignal.Client.V1.Endpoints.App
{
    public class CreateAppRequest
    {
        /// <summary>
        /// Required The name of your new app, as displayed on your apps list on the dashboard. This can be renamed later.
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// iOS - Either sandbox or production
        /// </summary>
        [JsonProperty("apns_env")]
        public String ApnsEnv { get; set; }

        /// <summary>
        /// iOS - Your apple push notification p12 certificate file, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("apns_p12")]
        public String ApnsP12 { get; set; }

        /// <summary>
        /// iOS - Password for the apns_p12 file
        /// </summary>
        [JsonProperty("apns_p12_password")]
        public String ApnsP12Password { get; set; }

        /// <summary>
        /// Android - Your Google Push Messaging Auth Key
        /// </summary>
        [JsonProperty("gcm_key")]
        public String GcmKey { get; set; }

        /// <summary>
        /// Android - Your Google Project number. Also know as Sender ID.
        /// </summary>
        [JsonProperty("android_gcm_sender_id")]
        public String AndroidGcmSenderId { get; set; }

        /// <summary>
        /// Chrome, Firefox - The URL to your website. This field is required if you wish to enable web push and specify other web push parameters.
        /// </summary>
        [JsonProperty("chrome_web_origin")]
        public String ChromeWebOrigin { get; set; }

        /// <summary>
        /// Chrome - Your default notification icon. Should be 80x80 pixels.
        /// </summary>
        [JsonProperty("chrome_web_default_notification_icon")]
        public String ChromeWebDefaultNotificationIcon { get; set; }

        /// <summary>
        /// Chrome - A subdomain of your choice in order to support Chrome Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed.
        /// </summary>
        [JsonProperty("chrome_web_sub_domain")]
        public String ChromeWebSubDomain { get; set; }

        /// <summary>
        /// Safari - Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("safari_apns_p12")]
        public String SafariApnsP12 { get; set; }

        /// <summary>
        /// Safari - Password for safari_apns_p12 file
        /// </summary>
        [JsonProperty("safari_apns_p12_password")]
        public String SafariApnsP12Password { get; set; }

        /// <summary>
        /// Safari - The URL to your website
        /// </summary>
        [JsonProperty("site_name")]
        public String SiteName { get; set; }

        /// <summary>
        /// Safari - The hostname to your website including http(s)://
        /// </summary>
        [JsonProperty("safari_site_origin")]
        public String SafariSiteOrigin { get; set; }

        /// <summary>
        /// Safari - A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide.
        /// </summary>
        [JsonProperty("safari_icon_256_256")]
        public String SafariIcon_256_256 { get; set; }

        /// <summary>
        /// Not for web pushYour Google Push Messaging Auth Key if you use Chrome Apps / Extensions.
        /// </summary>
        [JsonProperty("chrome_key")]
        public String ChromeKey { get; set; }

    }
}
