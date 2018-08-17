using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("HTMLScriptElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLScriptElement : HTMLElement
    {
        internal HTMLScriptElement(int handle) : base(handle) { }

        //public HTMLScriptElement () { }
        [Export("async")]
        public bool Async { get => GetProperty<bool>("async"); set => SetProperty<bool>("async", value); }
        [Export("charset")]
        public string Charset { get => GetProperty<string>("charset"); set => SetProperty<string>("charset", value); }
        [Export("crossOrigin")]
        public string CrossOrigin { get => GetProperty<string>("crossOrigin"); set => SetProperty<string>("crossOrigin", value); }
        [Export("defer")]
        public bool Defer { get => GetProperty<bool>("defer"); set => SetProperty<bool>("defer", value); }
        [Export("event")]
        public string Event { get => GetProperty<string>("event"); set => SetProperty<string>("event", value); }
        [Export("htmlFor")]
        public string HtmlFor { get => GetProperty<string>("htmlFor"); set => SetProperty<string>("htmlFor", value); }
        [Export("src")]
        public string Src { get => GetProperty<string>("src"); set => SetProperty<string>("src", value); }
        [Export("text")]
        public string Text { get => GetProperty<string>("text"); set => SetProperty<string>("text", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("integrity")]
        public string Integrity { get => GetProperty<string>("integrity"); set => SetProperty<string>("integrity", value); }
    }
}