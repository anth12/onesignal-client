using System;

namespace OneSignal.Client.Attributes
{
    public class KeyAttribute : Attribute
    {
        public KeyAttribute()
        {

        }
        public KeyAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
