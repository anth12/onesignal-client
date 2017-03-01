using System;

namespace OneSignal.Client.V1.Error
{
    public class OneSignalApiException : Exception
    {
        public OneSignalApiException()
        {

        }

        public OneSignalApiException(string message)
            : base(message)
        {

        }

        public OneSignalApiException(ErrorResponse response)
        {
            Response = response;
        }

        public ErrorResponse Response { get; set; }
    }
}
