using System;

namespace OneSignal.Client.V1.Endpoints
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
