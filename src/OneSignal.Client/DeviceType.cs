
namespace OneSignal.Client
{
    public enum DeviceType
    {
        /// <summary>
        /// APNS
        /// </summary>
        iOS = 0,

        /// <summary>
        /// GCM / Firebase
        /// </summary>
        Android = 1,

        /// <summary>
        /// APS
        /// </summary>
        Amazon = 2,

        /// <summary>
        /// MPNS
        /// </summary>
        WindowsPhone = 3,

        /// <summary>
        /// Chrome Apps / Extensions
        /// </summary>
        ChromeApp = 4,

        /// <summary>
        /// Chrome Web Push
        /// </summary>
        Chrome = 5,

        /// <summary>
        /// Windows Store
        /// </summary>
        Windows = 6,

        Safari = 7,

        FireFox = 8,

        MacOS = 9
    }
}
