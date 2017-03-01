using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OneSignal.Client.V1.Error;
using OneSignal.Client.Utilities;

namespace OneSignal.Client.V1.Endpoints
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

        protected async Task<TReturn> ExecutePostAsync<TReturn>(string apiPath, object parameters)
        {
            var requestContent = new FormUrlEncodedContent(parameters.ToKeyValue());

            //var requestContent = new StringContent(JsonConvert.SerializeObject(parameters));
            var response = await Parent.HttpClient.PostAsync(apiPath, requestContent);


            var json = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new OneSignalApiException(
                    JsonConvert.DeserializeObject<ErrorResponse>(json)
                );
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(response.StatusCode.ToString());
            }
            
            return JsonConvert.DeserializeObject<TReturn>(json);
        }

        protected async Task<TReturn> ExecutePutAsync<TReturn>(string apiPath, object parameters)
        {
            var requestContent = new FormUrlEncodedContent(parameters.ToKeyValue());

            var response = await Parent.HttpClient.PostAsync(apiPath, requestContent);


            var json = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new OneSignalApiException(
                    JsonConvert.DeserializeObject<ErrorResponse>(json)
                );
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(response.StatusCode.ToString());
            }

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

        protected async Task<TReturn> ExecuteDeleteAsync<TReturn>(string apiPath)
        {
            //var requestContent = new FormUrlEncodedContent(parameters.ToKeyValue());

            var response = await Parent.HttpClient.DeleteAsync(apiPath);


            var json = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new OneSignalApiException(
                    JsonConvert.DeserializeObject<ErrorResponse>(json)
                );
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(response.StatusCode.ToString());
            }

            return JsonConvert.DeserializeObject<TReturn>(json);
        }

    }
}
