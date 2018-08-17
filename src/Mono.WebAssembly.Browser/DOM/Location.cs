using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("Location", typeof(Mono.WebAssembly.JSObject))]
    public sealed class Location : JSObject
    {
        public Location(int handle) : base(handle) { }

        public Location() { }
        [Export("hash")]
        public string Hash { get => GetProperty<string>("hash"); set => SetProperty<string>("hash", value); }
        [Export("host")]
        public string Host { get => GetProperty<string>("host"); set => SetProperty<string>("host", value); }
        [Export("hostname")]
        public string Hostname { get => GetProperty<string>("hostname"); set => SetProperty<string>("hostname", value); }
        [Export("href")]
        public string Href { get => GetProperty<string>("href"); set => SetProperty<string>("href", value); }
        [Export("origin")]
        public string Origin => GetProperty<string>("origin");
        [Export("pathname")]
        public string Pathname { get => GetProperty<string>("pathname"); set => SetProperty<string>("pathname", value); }
        [Export("port")]
        public string Port { get => GetProperty<string>("port"); set => SetProperty<string>("port", value); }
        [Export("protocol")]
        public string Protocol { get => GetProperty<string>("protocol"); set => SetProperty<string>("protocol", value); }
        [Export("search")]
        public string Search { get => GetProperty<string>("search"); set => SetProperty<string>("search", value); }
        [Export("assign")]
        public void Assign(string url)
        {
            throw new NotImplementedException();
        }
        [Export("reload")]
        public void Reload(bool forcedReload)
        {
            InvokeMethod<object>("reload", forcedReload);
        }
        [Export("replace")]
        public void Replace(string url)
        {
            throw new NotImplementedException();
        }
        [Export("toString")]
        public override string ToString()
        {
            return InvokeMethod<string>("toString");
        }
    }
    
}