using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("HTMLTemplateElement", typeof(Mono.WebAssembly.JSObject))]
    public sealed class HTMLTemplateElement : HTMLElement, IHTMLTemplateElement
    {
        internal HTMLTemplateElement(int handle) : base(handle) { }

        //public HTMLTemplateElement() { }
        [Export("content")]
        public DocumentFragment Content => GetProperty<DocumentFragment>("content");
    }
}