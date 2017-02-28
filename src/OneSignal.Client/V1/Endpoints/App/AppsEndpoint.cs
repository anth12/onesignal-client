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

        public async Task<List<ViewAppResponse>> View()
        {
            return await ExecuteGetAsync<List<ViewAppResponse>>("apps");
        }

        public async Task<ViewAppResponse> View(string id)
        {
            return await ExecuteGetAsync<ViewAppResponse>($"apps/{id}");
        }
        //public CreateAppResponse Create(CreateAppRequest request) { }
        //public CreateAppResponse Update() { }
    }
}
