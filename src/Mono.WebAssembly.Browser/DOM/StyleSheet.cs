using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("StyleSheet", typeof(Mono.WebAssembly.JSObject))]
    public sealed class StyleSheet : JSObject
    {
        public StyleSheet(int handle) : base(handle) { }

        public StyleSheet() { }
        [Export("disabled")]
        public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
        [Export("href")]
        public string Href => GetProperty<string>("href");
        //[Export("media")]
        //public MediaList Media => GetProperty<MediaList>("media");
        [Export("ownerNode")]
        public Node OwnerNode => GetProperty<Node>("ownerNode");
        [Export("parentStyleSheet")]
        public StyleSheet ParentStyleSheet => GetProperty<StyleSheet>("parentStyleSheet");
        [Export("title")]
        public string Title => GetProperty<string>("title");
        [Export("type")]
        public string Type => GetProperty<string>("type");
    }
}