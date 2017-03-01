using System;
using System.Collections.Generic;
using OneSignal.Client.Utilities;
using FluentAssertions;
using OneSignal.Client.Attributes;
using Xunit;

namespace OneSignal.Client.Tests.Utilities
{
    public class KeyValuePairTests
    {
        [Fact]
        public void Can_cast_object_to_keyvalue_pair()
        {
            var source = new TestObject
            {
                Name = "Unit Test -1"
            };

            var result = source.ToKeyValue();

            result.Should().NotContain(new KeyValuePair<string, string>("Name", "Unit Test -1"));
            result.Should().Contain(new KeyValuePair<string, string>("alt_name", "Unit Test -1"));
        }

        private class TestObject
        {
            [Key("alt_name")]
            public String Name { get; set; }
        }
    }
}
