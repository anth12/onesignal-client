
namespace OneSignal.Client.V1.Endpoints.Notification
{
    public class NotificationsEndpoint : BaseEndpoint
    {
        internal NotificationsEndpoint(OneSignalClient parent)
            : base(parent)
        {
        }

        /// <summary>
        /// The Create Notification method is used when you want your server to programmatically 
        /// send notifications to a segment or individual users. You may target users in one of 
        /// three ways using this method: by Segment, by Filter, or by Device. 
        /// At least one targeting parameter must be specified.
        /// </summary>
        public void Create() { }

        public void Cancel() { }
        public void View() { }
        public void ViewAll() { }
        public void Track() { }
    }
}
