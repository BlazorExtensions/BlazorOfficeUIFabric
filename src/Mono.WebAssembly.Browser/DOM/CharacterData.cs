using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{
    [Export("CharacterData", typeof(Mono.WebAssembly.JSObject))]
    public class CharacterData : Node
    {
        internal CharacterData(int handle) : base(handle) { }

        //public CharacterData() { }
        [Export("data")]
        public string Data { get => GetProperty<string>("data"); set => SetProperty<string>("data", value); }
        [Export("length")]
        public double Length => GetProperty<double>("length");
        [Export("appendData")]
        public void AppendData(string arg)
        {
            InvokeMethod<object>("appendData", arg);
        }
        [Export("deleteData")]
        public void DeleteData(double offset, double count)
        {
            InvokeMethod<object>("deleteData", offset, count);
        }
        [Export("insertData")]
        public void InsertData(double offset, string arg)
        {
            InvokeMethod<object>("insertData", offset, arg);
        }
        [Export("replaceData")]
        public void ReplaceData(double offset, double count, string arg)
        {
            InvokeMethod<object>("replaceData", offset, count, arg);
        }
        [Export("substringData")]
        public string SubstringData(double offset, double count)
        {
            return InvokeMethod<string>("substringData", offset, count);
        }
        [Export("remove")]
        public void Remove()
        {
            InvokeMethod<object>("remove");
        }
    }
}
