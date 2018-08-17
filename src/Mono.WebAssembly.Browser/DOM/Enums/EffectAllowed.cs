using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public enum EffectAllowed
    {
        [Export(EnumValue = ConvertEnum.ToLower)]
        None,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Copy,
        [Export(EnumValue = ConvertEnum.ToLower)]
        CopyLink,
        [Export(EnumValue = ConvertEnum.ToLower)]
        CopyMove,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Link,
        [Export(EnumValue = ConvertEnum.ToLower)]
        LinkMove,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Move,
        [Export(EnumValue = ConvertEnum.ToLower)]
        UnInitialized,
        [Export(EnumValue = ConvertEnum.ToLower)]
        All,

    }
}
