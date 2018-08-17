using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("Attr", typeof(Mono.WebAssembly.JSObject))]
    public sealed class Attr : JSObject
    {
        internal Attr(int handle) : base(handle) { }

        internal Attr() { }

        [Export("name")]
        public string Name => GetProperty<string>("name");
        [Export("ownerElement")]
        public Element OwnerElement => GetProperty<Element>("ownerElement");
        [Export("prefix")]
        public string Prefix => GetProperty<string>("prefix");
        [Export("specified")]
        public bool Specified => GetProperty<bool>("specified");
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
    }

}