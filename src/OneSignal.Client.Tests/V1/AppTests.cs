using FluentAssertions;
using OneSignal.Client.V1;
using Xunit;

namespace OneSignal.Client.Tests.V1
{
    public class AppTests
    {
        [Fact]
        public async void Can_load_all_apps()
        {
            using (var client = new OneSignalClient(Constants.ApiKey))
            {
                var apps = await client.Apps.View();

                apps.Should().NotBeEmpty();
            }
        }

        [Fact]
        public async void Can_load_app()
        {
            using (var client = new OneSignalClient(Constants.ApiKey))
            {
                var app = await client.Apps.View(Constants.TestAppId);

                app.Name.Should().Be(Constants.TestAppName);
            }
        }
    }
}
