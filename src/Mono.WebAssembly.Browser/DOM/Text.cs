using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM 
{

    [Export("Text", typeof(Mono.WebAssembly.JSObject))]
    public class Text : CharacterData, IText
    {
        internal Text(int handle) : base(handle) { }

        //public Text(string data) { }
        [Export("wholeText")]
        public string WholeText => GetProperty<string>("wholeText");
        //[Export("assignedSlot")]
        //public HTMLSlotElement AssignedSlot => GetProperty<HTMLSlotElement>("assignedSlot");
        //[Export("splitText")]
        //public IText SplitText(double offset)
        //{
        //    return InvokeMethod<Text>("splitText", offset);
        //}
    }




}