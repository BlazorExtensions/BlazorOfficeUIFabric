using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLUListElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLUListElement : HTMLElement, IHTMLUListElement
    {
        internal HTMLUListElement(int handle) : base(handle) { }

        //public HTMLUListElement() { }
        [Export("compact")]
        public bool Compact { get => GetProperty<bool>("compact"); set => SetProperty<bool>("compact", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
    }

}