using System;
namespace Mono.WebAssembly.Browser.DOM
{

    [Export("DataTransferItem", typeof(Mono.WebAssembly.JSObject))]
    public sealed class DataTransferItem : JSObject
    {
        internal DataTransferItem(int handle) : base(handle) { }

        public DataTransferItem() { }
        [Export("kind")]
        public string Kind => GetProperty<string>("kind");
        [Export("type")]
        public string Type => GetProperty<string>("type");
        //[Export("getAsFile")]
        //public File GetAsFile()
        //{
        //  return InvokeMethod<File>("getAsFile");
        //}
        //[Export("getAsString")]
        //public void GetAsString(FunctionStringCallback _callback)
        //{
        //  InvokeMethod<object>("getAsString", _callback);
        //}
        //[Export("webkitGetAsEntry")]
        //public Object WebkitGetAsEntry()
        //{
        //  return InvokeMethod<Object>("webkitGetAsEntry");
        //}
    }

}
