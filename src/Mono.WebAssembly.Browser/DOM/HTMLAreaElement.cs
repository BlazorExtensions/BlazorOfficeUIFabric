using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLAreaElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLAreaElement : HTMLElement, IHTMLAreaElement
    {
        internal HTMLAreaElement(int handle) : base(handle) { }

        //public HTMLAreaElement() { }
        [Export("alt")]
        public string Alt { get => GetProperty<string>("alt"); set => SetProperty<string>("alt", value); }
        [Export("coords")]
        public string Coords { get => GetProperty<string>("coords"); set => SetProperty<string>("coords", value); }
        [Export("download")]
        public string Download { get => GetProperty<string>("download"); set => SetProperty<string>("download", value); }
        [Export("hash")]
        public string Hash { get => GetProperty<string>("hash"); set => SetProperty<string>("hash", value); }
        [Export("host")]
        public string Host { get => GetProperty<string>("host"); set => SetProperty<string>("host", value); }
        [Export("hostname")]
        public string Hostname { get => GetProperty<string>("hostname"); set => SetProperty<string>("hostname", value); }
        [Export("href")]
        public string Href { get => GetProperty<string>("href"); set => SetProperty<string>("href", value); }
        [Export("noHref")]
        public bool NoHref { get => GetProperty<bool>("noHref"); set => SetProperty<bool>("noHref", value); }
        [Export("pathname")]
        public string Pathname { get => GetProperty<string>("pathname"); set => SetProperty<string>("pathname", value); }
        [Export("port")]
        public string Port { get => GetProperty<string>("port"); set => SetProperty<string>("port", value); }
        [Export("protocol")]
        public string Protocol { get => GetProperty<string>("protocol"); set => SetProperty<string>("protocol", value); }
        [Export("rel")]
        public string Rel { get => GetProperty<string>("rel"); set => SetProperty<string>("rel", value); }
        [Export("search")]
        public string Search { get => GetProperty<string>("search"); set => SetProperty<string>("search", value); }
        [Export("shape")]
        public string Shape { get => GetProperty<string>("shape"); set => SetProperty<string>("shape", value); }
        [Export("target")]
        public string Target { get => GetProperty<string>("target"); set => SetProperty<string>("target", value); }
        [Export("toString")]
        public override string ToString()
        {
            return InvokeMethod<string>("toString");
        }
    }
}