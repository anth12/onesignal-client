using System;
using OneSignal.Client.Attributes;

namespace OneSignal.Client.V1.Endpoints.Notification
{
    public class ViewNotificationRequest
    {
        /// <summary>
        /// Safari - Password for safari_apns_p12 file
        /// </summary>
        [Key("safari_apns_p12_password")]
        public String SafariApnsP12Password { get; set; }

        /// <summary>
        /// Safari - The URL to your website
        /// </summary>
        [Key("site_name")]
        public String SiteName { get; set; }

        /// <summary>
        /// Safari - The hostname to your website including http(s)://
        /// </summary>
        [Key("safari_site_origin")]
        public String SafariSiteOrigin { get; set; }

        /// <summary>
        /// Safari - A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide.
        /// </summary>
        [Key("safari_icon_256_256")]
        public String SafariIcon_256_256 { get; set; }

        /// <summary>
        /// Not for web pushYour Google Push Messaging Auth Key if you use Chrome Apps / Extensions.
        /// </summary>
        [Key("chrome_key")]
        public String ChromeKey { get; set; }

    }
}
