using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLMetaElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLMetaElement : HTMLElement, IHTMLMetaElement
    {
        internal HTMLMetaElement(int handle) : base(handle) { }

        //public HTMLMetaElement() { }
        [Export("charset")]
        public string Charset { get => GetProperty<string>("charset"); set => SetProperty<string>("charset", value); }
        [Export("content")]
        public string Content { get => GetProperty<string>("content"); set => SetProperty<string>("content", value); }
        [Export("httpEquiv")]
        public string HttpEquiv { get => GetProperty<string>("httpEquiv"); set => SetProperty<string>("httpEquiv", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("scheme")]
        public string Scheme { get => GetProperty<string>("scheme"); set => SetProperty<string>("scheme", value); }
        [Export("url")]
        public string Url { get => GetProperty<string>("url"); set => SetProperty<string>("url", value); }
    }
}