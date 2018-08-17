using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLHeadElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLHeadElement : HTMLElement
    {
        internal HTMLHeadElement(int handle) : base(handle) { }

        //public HTMLHeadElement() { }
        [Export("profile")]
        public string Profile { get => GetProperty<string>("profile"); set => SetProperty<string>("profile", value); }
    }
}