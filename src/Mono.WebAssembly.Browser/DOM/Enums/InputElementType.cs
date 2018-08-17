using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public enum InputElementType
    {
        [Export(EnumValue = ConvertEnum.ToLower)]
        Button,
        [Export(EnumValue = ConvertEnum.ToLower)]
        CheckBox,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Color,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Date,
        [Export("datetime-local")]
        DateTimeLocal,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Email,
        //        [Export(EnumValue = ConvertEnum.ToLower)]
        //File
        [Export(EnumValue = ConvertEnum.ToLower)]
        Hidden,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Image,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Month,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Number,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Password,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Radio,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Range,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Reset,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Search,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Submit,
        [Export("tel")]
        Telephone,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Text,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Time,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Url,
        [Export(EnumValue = ConvertEnum.ToLower)]
        Week,

    }
}
