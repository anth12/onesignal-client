using System.Collections.Generic;
using System.Reflection;
using OneSignal.Client.Attributes;

namespace OneSignal.Client.Utilities
{
    public static class KeyValuePairExtension
    {
        
        public static IList<KeyValuePair<string, string>> ToKeyValue(this object source)
        {
            var result = new List<KeyValuePair<string, string>>();

            var type = source.GetType();

            foreach(var property in type.GetTypeInfo().DeclaredProperties)
            {
                var propertyName = property.GetCustomAttribute<KeyAttribute>()?.Name ?? property.Name;

                var value = property.GetValue(source);

                result.Add(new KeyValuePair<string, string>(propertyName, value != null ? value.ToString() : null));
            }

            return result;
        }
    }
}
