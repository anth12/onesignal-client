using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneSignal.Client.V1.Endpoints.App
{
    public class AppsEndpoint : BaseEndpoint
    {
        internal AppsEndpoint(OneSignalClient parent)
            : base(parent)
        {
        }

        /// <summary>
        /// View the details of all of your current OneSignal apps
        /// </summary>
        /// <returns></returns>
        public async Task<List<ViewAppResponse>> View()
        {
            return await ExecuteGetAsync<List<ViewAppResponse>>("apps");
        }

        /// <summary>
        /// View the details of a single OneSignal app
        /// </summary>
        /// <param name="id">An app id</param>
        /// <returns></returns>
        public async Task<ViewAppResponse> View(string id)
        {
            return await ExecuteGetAsync<ViewAppResponse>($"apps/{id}");
        }

        /// <summary>
        /// Creates a new OneSignal app
        /// </summary>
        /// <returns></returns>
        public async Task<CreateAppResponse> Create(ViewDevicesRequest request)
        {
            return await ExecutePostAsync<CreateAppResponse>("apps", request);
        }

        /// <summary>
        /// Updates the name or configuration settings of an existing OneSignal app
        /// </summary>
        /// <param name="id">An app id</param>
        /// <returns></returns>
        public async Task<CreateAppResponse> Update(string id, ViewDevicesRequest request)
        {
            return await ExecutePutAsync<CreateAppResponse>($"apps/{id}", request);
        }        

    }
}
