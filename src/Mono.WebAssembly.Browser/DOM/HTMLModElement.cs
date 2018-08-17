using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLModElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLModElement : HTMLElement, IHTMLModElement {
    internal HTMLModElement  (int handle) : base (handle) {}

    //public HTMLModElement () { }
    [Export("cite")]
    public string Cite { get => GetProperty<string>("cite"); set => SetProperty<string>("cite", value); }
    [Export("dateTime")]
    public string DateTime { get => GetProperty<string>("dateTime"); set => SetProperty<string>("dateTime", value); }
}
}