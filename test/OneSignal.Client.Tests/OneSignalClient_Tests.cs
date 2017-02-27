using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneSignal.Client.Tests
{
    
    [TestClass]
    public class OneSignalClient_Tests
    {
        [TestMethod]
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
