using System;

namespace OneSignal.Client.Endpoints
{
    public class DevicesEndpoint : BaseEndpoint
    {
        internal DevicesEndpoint(OneSignalClient parent)
            : base(parent)
        {
        }

        public void View() { }
        public void View(Guid id) { }
        public void Add() { }
        public void Edit() { }
    }
}
