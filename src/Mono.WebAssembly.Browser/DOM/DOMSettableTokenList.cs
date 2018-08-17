using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("DOMSettableTokenList", typeof(Mono.WebAssembly.JSObject))]
    public sealed class DOMSettableTokenList : DOMTokenList, IDOMSettableTokenList
    {
        internal DOMSettableTokenList(int handle) : base(handle) { }

        //public DOMSettableTokenList() { }
        [Export("value")]
        public string Value { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
    }
}