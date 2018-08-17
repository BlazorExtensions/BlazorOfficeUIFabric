using System;
using System.Runtime.CompilerServices;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{


    [Export("NamedNodeMap", typeof(Mono.WebAssembly.JSObject))]
    public sealed class NamedNodeMap : JSObject
    {
        public NamedNodeMap(int handle) : base(handle) { }

        public NamedNodeMap() { }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("getNamedItem")]
        public Attr GetNamedItem(string name)
        {
            return InvokeMethod<Attr>("getNamedItem", name);
        }
        [Export("getNamedItemNS")]
        public Attr GetNamedItemNs(string namespaceURI, string localName)
        {
            return InvokeMethod<Attr>("getNamedItemNS", namespaceURI, localName);
        }
        [Export("item")]
        public Attr Item(double index)
        {
            return InvokeMethod<Attr>("item", index);
        }
        [Export("removeNamedItem")]
        public Attr RemoveNamedItem(string name)
        {
            return InvokeMethod<Attr>("removeNamedItem", name);
        }
        [Export("removeNamedItemNS")]
        public Attr RemoveNamedItemNs(string namespaceURI, string localName)
        {
            return InvokeMethod<Attr>("removeNamedItemNS", namespaceURI, localName);
        }
        [Export("setNamedItem")]
        public Attr SetNamedItem(Attr arg)
        {
            return InvokeMethod<Attr>("setNamedItem", arg);
        }
        [Export("setNamedItemNS")]
        public Attr SetNamedItemNs(Attr arg)
        {
            return InvokeMethod<Attr>("setNamedItemNS", arg);
        }
        [IndexerName("TheItem")]
        public Attr this[double index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}