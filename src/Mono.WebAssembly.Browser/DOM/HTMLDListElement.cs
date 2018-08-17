using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLDListElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLDListElement : HTMLElement, IHTMLDListElement {
    internal HTMLDListElement  (int handle) : base (handle) {}

    //public HTMLDListElement () { }
    [Export("compact")]
    public bool Compact { get => GetProperty<bool>("compact"); set => SetProperty<bool>("compact", value); }
}

}