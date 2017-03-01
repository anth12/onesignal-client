using FluentAssertions;
using OneSignal.Client.V1;
using OneSignal.Client.V1.Endpoints.App;
using OneSignal.Client.V1.Error;
using System;
using System.Linq;
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

        #region Create

        [Fact]
        public async void Cannot_create_invalid_app()
        {
            OneSignalApiException error = null;

            using (var client = new OneSignalClient(Constants.ApiKey))
            {
                try
                {
                    var app = await client.Apps.Create(new CreateAppRequest());
                }catch(OneSignalApiException ex)
                {
                    error = ex;
                }

                error.Should().NotBeNull();
                error.Response.Errors.Should().Contain("Name Enter an app name");
            }
        }

        [Fact]
        public async void Can_create_app()
        {
            using (var client = new OneSignalClient(Constants.ApiKey))
            {
                var name = "[test] " + Guid.NewGuid();
                var app = await client.Apps.Create(new CreateAppRequest
                {
                    Name = name
                });
                
                app.Name.Should().Be(name);
            }
        }

        #endregion
        
    }
}
