using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLHRElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLHRElement : HTMLElement, IHTMLHRElement {
    internal HTMLHRElement  (int handle) : base (handle) {}

    //public HTMLHRElement () { }
    [Export("align")]
    public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
    [Export("noShade")]
    public bool NoShade { get => GetProperty<bool>("noShade"); set => SetProperty<bool>("noShade", value); }
    [Export("width")]
    public double Width { get => GetProperty<double>("width"); set => SetProperty<double>("width", value); }
    [Export("color")]
    public string Color { get => GetProperty<string>("color"); set => SetProperty<string>("color", value); }
    [Export("size")]
    public double Size { get => GetProperty<double>("size"); set => SetProperty<double>("size", value); }
}
}