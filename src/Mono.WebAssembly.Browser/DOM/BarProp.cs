using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("BarProp", typeof(Mono.WebAssembly.JSObject))]
    public sealed class BarProp : JSObject
    {
        internal BarProp(int handle) : base(handle) { }

        //public BarProp() { }
        [Export("visible")]
        public bool Visible => GetProperty<bool>("visible");
    }
}