using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLDirectoryElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLDirectoryElement : HTMLElement, IHTMLDirectoryElement {
    internal HTMLDirectoryElement  (int handle) : base (handle) {}

    //public HTMLDirectoryElement () { }
    [Export("compact")]
    public bool Compact { get => GetProperty<bool>("compact"); set => SetProperty<bool>("compact", value); }
}

}