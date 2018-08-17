using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLSourceElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLSourceElement : HTMLElement, IHTMLSourceElement {
    internal HTMLSourceElement  (int handle) : base (handle) {}

    //public HTMLSourceElement () { }
    [Export("media")]
    public string Media { get => GetProperty<string>("media"); set => SetProperty<string>("media", value); }
    [Export("msKeySystem")]
    public string MsKeySystem { get => GetProperty<string>("msKeySystem"); set => SetProperty<string>("msKeySystem", value); }
    [Export("sizes")]
    public string Sizes { get => GetProperty<string>("sizes"); set => SetProperty<string>("sizes", value); }
    [Export("src")]
    public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
    [Export("srcset")]
    public string Srcset { get => GetProperty<string>("srcset"); set => SetProperty<string>("srcset", value); }
    [Export("type")]
    public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
}
}