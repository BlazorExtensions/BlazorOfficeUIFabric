using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLOptionElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLOptionElement : HTMLElement
    {
        internal HTMLOptionElement(int handle) : base(handle) { }

        //public HTMLOptionElement () { }
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
        public string Text { get => GetProperty<string>("text"); set => SetProperty<string>("text", value); }
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
    }
}