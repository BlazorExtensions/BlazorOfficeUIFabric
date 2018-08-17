using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("URLSearchParams", typeof(Mono.WebAssembly.JSObject))]
    public sealed class URLSearchParams : JSObject
    {
        internal URLSearchParams(int handle) : base(handle) { }

        //public URLSearchParams (object init) { }
        [Export("append")]
        public void Append(string name, string value)
        {
            InvokeMethod<object>("append", name, value);
        }
        [Export("delete")]
        public void Delete(string name)
        {
            InvokeMethod<object>("delete", name);
        }
        [Export("get")]
        public string Get(string name)
        {
            return InvokeMethod<
        string>("get", name);
        }
        [Export("getAll")]
        public string[] GetAll(string name)
        {
            return InvokeMethod<string[]>("getAll", name);
        }
        [Export("has")]
        public bool Has(string name)
        {
            return InvokeMethod<bool>("has", name);
        }
        [Export("set")]
        public void Set(string name, string value)
        {
            InvokeMethod<object>("set", name, value);
        }
    }

}