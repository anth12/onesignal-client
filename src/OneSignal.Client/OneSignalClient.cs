using System;
using System.Net.Http;
using OneSignal.Client.Endpoints;
using OneSignal.Client.Endpoints.App;

namespace OneSignal.Client
{
    public class OneSignalClient : IDisposable
    {
        private string _apiKey;
        internal const string ApiEndpoint = "https://onesignal.com/api/v1";
        internal HttpClient HttpClient;

        public OneSignalClient(string apiKey)
        {
            _apiKey = apiKey;

            // Configure the Http Client
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiEndpoint)
            };
            HttpClient.DefaultRequestHeaders.Add("authorization", $"Basic {_apiKey}");
            
            // Initialize the endpoints
            Apps = new AppsEndpoint(this);
            DevicesEndpoint = new DevicesEndpoint(this);
            Notifications = new NotificationsEndpoint(this);
        }

        public AppsEndpoint Apps { get; }
        public DevicesEndpoint DevicesEndpoint { get; }
        public NotificationsEndpoint Notifications { get; }

        #region IDisposable
        public void Dispose()
        {
            HttpClient.Dispose();
        }
        #endregion

    }
}
