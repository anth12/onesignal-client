using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OneSignal.Client.Endpoints
{
    public abstract class BaseEndpoint
    {
        protected readonly OneSignalClient Parent;
        protected BaseEndpoint(OneSignalClient parent)
        {
            Parent = parent;
        }

        protected async Task<TReturn> ExecuteGetAsync<TReturn>(string apiPath)
        {
            var response = await Parent.HttpClient.GetAsync(apiPath);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException();
            }

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

        protected async Task<TReturn> ExecutePostAsync<TReturn, TParam>(string apiPath, TParam parameters)
        {
            var requestContent = new StringContent("");

            var response = await Parent.HttpClient.PostAsync(apiPath, requestContent);


            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException();
            }

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

        protected async Task<TReturn> ExecutePutAsync<TReturn, TParam>(string apiPath, TParam parameters)
        {
            var requestContent = new StringContent("");

            var response = await Parent.HttpClient.PostAsync(apiPath, requestContent);


            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException();
            }

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

        protected async Task<TReturn> ExecuteDeleteAsync<TReturn, TParam>(string apiPath, TParam parameters)
        {
            var requestContent = new StringContent("");

            var response = await Parent.HttpClient.PostAsync(apiPath, requestContent);


            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException();
            }

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

    }
}
