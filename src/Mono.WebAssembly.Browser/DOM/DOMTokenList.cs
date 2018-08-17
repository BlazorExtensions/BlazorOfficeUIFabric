using System;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{
    [Export("DOMTokenList", typeof(Mono.WebAssembly.JSObject))]
    public class DOMTokenList : JSObject
    {
        public DOMTokenList(int handle) : base(handle) { }

        public DOMTokenList() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("add")]
        public void Add(params string[] token)
        {
            InvokeMethod<object>("add", token);
        }
        [Export("contains")]
        public bool Contains(string token)
        {
            return InvokeMethod<bool>("contains", token);
        }
        [Export("item")]
        public string Item(double index)
        {
            return InvokeMethod<string>("item", index);
        }
        [Export("remove")]
        public void Remove(params string[] token)
        {
            InvokeMethod<object>("remove", token);
        }
        [Export("toggle")]
        public bool Toggle(string token, bool force)
        {
            return InvokeMethod<bool>("toggle", token, force);
        }
        [Export("toggle")]
        public bool Toggle(string token)
        {
            return InvokeMethod<bool>("toggle", token);
        }
        [Export("toString")]
        public override string ToString()
        {
            return InvokeMethod<string>("toString");
        }
        [IndexerName("TheItem")]
        public string this[double index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}