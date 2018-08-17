using System;
namespace Mono.WebAssembly.Browser.DOM
{
    //type InsertPosition = "beforebegin" | "afterbegin" | "beforeend" | "afterend";
    public enum InsertPosition
    {
        [Export(EnumValue = ConvertEnum.ToLower)]
        BeforeBegin,
        [Export(EnumValue = ConvertEnum.ToLower)]
        AfterBegin,
        [Export(EnumValue = ConvertEnum.ToLower)]
        BeforeEnd,
        [Export(EnumValue = ConvertEnum.ToLower)]
        AfterEnd,
    }
}
