using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

[Export("HTMLOptGroupElement", typeof(Mono.WebAssembly.JSObject))]
public sealed class HTMLOptGroupElement : HTMLElement, IHTMLOptGroupElement {
    internal HTMLOptGroupElement  (int handle) : base (handle) {}

    //public HTMLOptGroupElement () { }
    [Export("defaultSelected")]
    public bool DefaultSelected { get => GetProperty<bool>("defaultSelected"); set => SetProperty<bool>("defaultSelected", value); }
    [Export("disabled")]
    public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
    [Export("form")]
    public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
    [Export("index")]
    public double Index => GetProperty<double>("index");
    [Export("label")]
    public string Label { get => GetProperty<string>("label"); set => SetProperty<string>("label", value); }
    [Export("selected")]
    public bool Selected { get => GetProperty<bool>("selected"); set => SetProperty<bool>("selected", value); }
    [Export("text")]
    public string Text => GetProperty<string>("text");
    [Export("value")]
    public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
}
}