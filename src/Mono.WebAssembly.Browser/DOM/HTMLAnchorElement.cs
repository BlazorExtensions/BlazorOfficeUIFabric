using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

    [Export("HTMLAnchorElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLAnchorElement : HTMLElement, IHTMLAnchorElement
    {
        internal HTMLAnchorElement(int handle) : base(handle) { }

        //public HTMLAnchorElement() { }
        [Export("charset")]
        public string Charset { get => GetProperty<string>("charset"); set => SetProperty<string>("charset", value); }
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
        [Export("hreflang")]
        public string Hreflang { get => GetProperty<string>("hreflang"); set => SetProperty<string>("hreflang", value); }
        [Export("Methods")]
        public string Methods { get => GetProperty<string>("Methods"); set => SetProperty<string>("Methods", value); }
        [Export("mimeType")]
        public string MimeType => GetProperty<string>("mimeType");
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("nameProp")]
        public string NameProp => GetProperty<string>("nameProp");
        [Export("pathname")]
        public string Pathname { get => GetProperty<string>("pathname"); set => SetProperty<string>("pathname", value); }
        [Export("port")]
        public string Port { get => GetProperty<string>("port"); set => SetProperty<string>("port", value); }
        [Export("protocol")]
        public string Protocol { get => GetProperty<string>("protocol"); set => SetProperty<string>("protocol", value); }
        [Export("protocolLong")]
        public string ProtocolLong => GetProperty<string>("protocolLong");
        [Export("rel")]
        public string Rel { get => GetProperty<string>("rel"); set => SetProperty<string>("rel", value); }
        [Export("rev")]
        public string Rev { get => GetProperty<string>("rev"); set => SetProperty<string>("rev", value); }
        [Export("search")]
        public string Search { get => GetProperty<string>("search"); set => SetProperty<string>("search", value); }
        [Export("shape")]
        public string Shape { get => GetProperty<string>("shape"); set => SetProperty<string>("shape", value); }
        [Export("target")]
        public string Target { get => GetProperty<string>("target"); set => SetProperty<string>("target", value); }
        [Export("text")]
        public string Text { get => GetProperty<string>("text"); set => SetProperty<string>("text", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("urn")]
        public string Urn { get => GetProperty<string>("urn"); set => SetProperty<string>("urn", value); }
        [Export("toString")]
        public override string ToString()
        {
            return InvokeMethod<string>("toString");
        }
    }
}