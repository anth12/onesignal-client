using FluentAssertions;
using OneSignal.Client.V1;
using Xunit;

namespace OneSignal.Client.Tests
{
    public class OneSignalClient_Tests
    {
        [Fact]
        public async void Can_connect()
        {
            using (var client = new OneSignalClient("M2JiYmM4NzEtYTgxNy00NGU0LWIzODktMzFmNDI5YjRiODU5"))
            {
                var apps = await client.Apps.View();

                apps.Should().NotBeEmpty();

                foreach (var app in apps)
                {

                }
            }
        }
    }
}
