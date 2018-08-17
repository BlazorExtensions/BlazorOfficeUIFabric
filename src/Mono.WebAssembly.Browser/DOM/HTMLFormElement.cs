using System;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLFormElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLFormElement : HTMLElement, IHTMLFormElement
    {
        internal HTMLFormElement(int handle) : base(handle) { }

        //public HTMLFormElement () { }
        [Export("acceptCharset")]
        public string AcceptCharset { get => GetProperty<string>("acceptCharset"); set => SetProperty<string>("acceptCharset", value); }
        [Export("action")]
        public string Action { get => GetProperty<string>("action"); set => SetProperty<string>("action", value); }
        [Export("autocomplete")]
        public string Autocomplete { get => GetProperty<string>("autocomplete"); set => SetProperty<string>("autocomplete", value); }
        [Export("elements")]
        public HTMLFormControlsCollection Elements => GetProperty<HTMLFormControlsCollection>("elements");
        [Export("encoding")]
        public string Encoding { get => GetProperty<string>("encoding"); set => SetProperty<string>("encoding", value); }
        [Export("enctype")]
        public string Enctype { get => GetProperty<string>("enctype"); set => SetProperty<string>("enctype", value); }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("method")]
        public string Method { get => GetProperty<string>("method"); set => SetProperty<string>("method", value); }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("noValidate")]
        public bool NoValidate { get => GetProperty<bool>("noValidate"); set => SetProperty<bool>("noValidate", value); }
        [Export("target")]
        public string Target { get => GetProperty<string>("target"); set => SetProperty<string>("target", value); }
        [Export("checkValidity")]
        public bool CheckValidity()
        {
            return InvokeMethod<bool>("checkValidity");
        }
        [Export("item")]
        public Element Item(string name)
        {
            return GetProperty<Element>(name);
        }
        [Export("item")]
        public Element Item(int index)
        {
            return GetProperty<Element>(index.ToString());
        }
        [Export("namedItem")]
        public Element NamedItem(string name)
        {
            return Item(name);
        }
        [Export("reset")]
        public void Reset()
        {
            InvokeMethod<object>("reset");
        }
        [Export("submit")]
        public void Submit()
        {
            InvokeMethod<object>("submit");
        }
        [Export("reportValidity")]
        public bool ReportValidity()
        {
            return InvokeMethod<bool>("reportValidity");
        }
        [IndexerName("TheItem")]
        public Element this[string name] { get => Item(name); set => throw new NotImplementedException(); }
    }

}