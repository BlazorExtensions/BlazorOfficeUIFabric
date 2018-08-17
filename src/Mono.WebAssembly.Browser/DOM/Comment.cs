using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.Browser.DOM
{

    [Export("Comment", typeof(Mono.WebAssembly.JSObject))]
    public sealed class Comment : CharacterData, IComment
    {
        internal Comment(int handle) : base(handle) { }

        //public Comment () { }
        [Export("text")]
        public string Text { get => GetProperty<string>("text"); set => SetProperty<string>("text", value); }
    }
}