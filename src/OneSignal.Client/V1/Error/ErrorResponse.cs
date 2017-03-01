using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal.Client.V1.Error
{
    public class ErrorResponse
    {

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}
