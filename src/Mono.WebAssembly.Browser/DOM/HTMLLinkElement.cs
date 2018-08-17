using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{



    [Export("HTMLLinkElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLLinkElement : HTMLElement, IHTMLLinkElement
    {
        internal HTMLLinkElement(int handle) : base(handle) { }

        //public HTMLLinkElement() { }

        /**
         * Sets or retrieves the character set used to encode the object.
         */
        [Export("charset")]
        public string Charset { get => GetProperty<string>("charset"); set => SetProperty<string>("charset", value); }
        [Export("disabled")]
        public bool Disabled { get => GetProperty<bool>("disabled"); set => SetProperty<bool>("disabled", value); }
        /**
         * Sets or retrieves a destination URL or an anchor point.
         */
        [Export("href")]
        public string Href { get => GetProperty<string>("href"); set => SetProperty<string>("href", value); }
        /**
         * Sets or retrieves the language code of the object.
         */
        [Export("hreflang")]
        public string Hreflang { get => GetProperty<string>("hreflang"); set => SetProperty<string>("hreflang", value); }
        /**
         * Sets or retrieves the media type.
         */
        [Export("media")]
        public string Media { get => GetProperty<string>("media"); set => SetProperty<string>("media", value); }
        /**
         * Sets or retrieves the relationship between the object and the destination of the link.
         */
        [Export("rel")]
        public string Rel { get => GetProperty<string>("rel"); set => SetProperty<string>("rel", value); }
        /**
         * Sets or retrieves the relationship between the object and the destination of the link.
         */
        [Export("rev")]
        public string Rev { get => GetProperty<string>("rev"); set => SetProperty<string>("rev", value); }
        /**
         * Sets or retrieves the window or frame at which to target content.
         */
        [Export("target")]
        public string Target { get => GetProperty<string>("target"); set => SetProperty<string>("target", value); }
        /**
         * Sets or retrieves the MIME type of the object.
         */
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("import")]
        public Document Import { get => GetProperty<Document>("import"); set => SetProperty<Document>("import", value); }
        [Export("integrity")]
        public string Integrity { get => GetProperty<string>("integrity"); set => SetProperty<string>("integrity", value); }
        [Export("sheet")]
        public StyleSheet Sheet => GetProperty<StyleSheet>("sheet");
    }

}