using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("HTMLAppletElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLAppletElement : HTMLElement, IHTMLAppletElement
    {
        internal HTMLAppletElement(int handle) : base(handle) { }

        //public HTMLAppletElement () { }
        [Export("align")]
        public string Align { get => GetProperty<string>("align"); set => SetProperty<string>("align", value); }
        [Export("alt")]
        public string Alt { get => GetProperty<string>("alt"); set => SetProperty<string>("alt", value); }
        [Export("altHtml")]
        public string AltHtml { get => GetProperty<string>("altHtml"); set => SetProperty<string>("altHtml", value); }
        [Export("archive")]
        public string Archive { get => GetProperty<string>("archive"); set => SetProperty<string>("archive", value); }
        [Export("BaseHref")]
        public string BaseHref => GetProperty<string>("BaseHref");
        [Export("border")]
        public string Border { get => GetProperty<string>("border"); set => SetProperty<string>("border", value); }
        [Export("code")]
        public string Code { get => GetProperty<string>("code"); set => SetProperty<string>("code", value); }
        [Export("codeBase")]
        public string CodeBase { get => GetProperty<string>("codeBase"); set => SetProperty<string>("codeBase", value); }
        [Export("codeType")]
        public string CodeType { get => GetProperty<string>("codeType"); set => SetProperty<string>("codeType", value); }
        [Export("contentDocument")]
        public Document ContentDocument => GetProperty<Document>("contentDocument");
        [Export("data")]
        public string Data { get => GetProperty<string>("data"); set => SetProperty<string>("data", value); }
        [Export("declare")]
        public bool Declare { get => GetProperty<bool>("declare"); set => SetProperty<bool>("declare", value); }
        [Export("form")]
        public HTMLFormElement Form => GetProperty<HTMLFormElement>("form");
        [Export("height")]
        public string Height { get => GetProperty<string>("height"); set => SetProperty<string>("height", value); }
        [Export("hspace")]
        public double Hspace { get => GetProperty<double>("hspace"); set => SetProperty<double>("hspace", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("object")]
        public string Object { get => GetProperty<string>("object"); set => SetProperty<string>("object", value); }
        [Export("standby")]
        public string Standby { get => GetProperty<string>("standby"); set => SetProperty<string>("standby", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("useMap")]
        public string UseMap { get => GetProperty<string>("useMap"); set => SetProperty<string>("useMap", value); }
        [Export("vspace")]
        public double Vspace { get => GetProperty<double>("vspace"); set => SetProperty<double>("vspace", value); }
        [Export("width")]
        public double Width { get => GetProperty<double>("width"); set => SetProperty<double>("width", value); }
    }
}