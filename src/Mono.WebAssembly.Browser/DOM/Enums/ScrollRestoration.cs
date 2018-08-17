using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public enum ScrollRestoration
    {
        [Export(EnumValue = ConvertEnum.ToLower)]
        Auto,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Manual
    }
}
