using Mono.WebAssembly.Browser.DOM;
using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling
{
    public class StyleRecord
    {
        public Element StyleElement { get; set; }

        public ICollection<ThemingInstruction> ThemableStyle { get; set; }
    }
}