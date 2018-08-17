// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do one of these:
//
//    using Blazor.Extensions.MergeStyles;
//
//    var icssRule = IcssRule.FromJson(jsonString);
//    var icssPercentageRule = IcssPercentageRule.FromJson(jsonString);
//    var icssPixelUnitRule = IcssPixelUnitRule.FromJson(jsonString);
//    var iFontWeight = IFontWeight.FromJson(jsonString);
//    var iRawFontStyle = IRawFontStyle.FromJson(jsonString);
//    var iFontFace = IFontFace.FromJson(jsonString);
//    var iRawStyleBase = IRawStyleBase.FromJson(jsonString);

namespace Blazor.Extensions.MergeStyles
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The base font style.
    /// </summary>
    public partial class IRawFontStyle
    {
       


        /// <summary>
        /// The font property is shorthand that allows you to do one of two things: you can
        /// either set up six of the most mature font properties in one line, or you can set
        /// one of a choice of keywords to adopt a system font setting.
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font { get; set; }

        /// <summary>
        /// The font-family property allows one or more font family names and/or generic family
        /// names to be specified for usage on the selected element(s)' text. The browser then
        /// goes through the list; for each character in the selection it applies the first
        /// font family that has an available glyph for that character.
        /// </summary>
        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string FontFamily { get; set; }

        /// <summary>
        /// The font-kerning property allows contextual adjustment of inter-glyph spacing, i.e.
        /// the spaces between the characters in text. This property controls <bold>metric
        /// kerning</bold> - that utilizes adjustment data contained in the font. Optical
        /// Kerning is not supported as yet.
        /// </summary>
        [JsonProperty("fontKerning", NullValueHandling = NullValueHandling.Ignore)]
        public string FontKerning { get; set; }

        /// <summary>
        /// Specifies the size of the font. Used to compute em and ex units.
        /// See CSS 3 font-size property https://www.w3.org/TR/css-fonts-3/#propdef-font-size
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? FontSize { get; set; }

        /// <summary>
        /// The font-size-adjust property adjusts the font-size of the fallback fonts defined
        /// with font-family, so that the x-height is the same no matter what font is used.
        /// This preserves the readability of the text when fallback happens.
        /// See CSS 3 font-size-adjust property
        /// https://www.w3.org/TR/css-fonts-3/#propdef-font-size-adjust
        /// </summary>
        [JsonProperty("fontSizeAdjust", NullValueHandling = NullValueHandling.Ignore)]
        public FontSizeAdjust? FontSizeAdjust { get; set; }

        /// <summary>
        /// Allows you to expand or condense the widths for a normal, condensed, or expanded
        /// font face.
        /// See CSS 3 font-stretch property
        /// https://drafts.csswg.org/css-fonts-3/#propdef-font-stretch
        /// </summary>
        [JsonProperty("fontStretch", NullValueHandling = NullValueHandling.Ignore)]
        public FontStretch? FontStretch { get; set; }

        /// <summary>
        /// The font-style property allows normal, italic, or oblique faces to be selected.
        /// Italic forms are generally cursive in nature while oblique faces are typically
        /// sloped versions of the regular face. Oblique faces can be simulated by artificially
        /// sloping the glyphs of the regular face.
        /// See CSS 3 font-style property https://www.w3.org/TR/css-fonts-3/#propdef-font-style
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public FontStyle? FontStyle { get; set; }

        /// <summary>
        /// This value specifies whether the user agent is allowed to synthesize bold or
        /// oblique font faces when a font family lacks bold or italic faces.
        /// </summary>
        [JsonProperty("fontSynthesis", NullValueHandling = NullValueHandling.Ignore)]
        public string FontSynthesis { get; set; }

        /// <summary>
        /// The font-variant property enables you to select the small-caps font within a font
        /// family.
        /// </summary>
        [JsonProperty("fontVariant", NullValueHandling = NullValueHandling.Ignore)]
        public string FontVariant { get; set; }

        /// <summary>
        /// Fonts can provide alternate glyphs in addition to default glyph for a character.
        /// This property provides control over the selection of these alternate glyphs.
        /// </summary>
        [JsonProperty("fontVariantAlternates", NullValueHandling = NullValueHandling.Ignore)]
        public string FontVariantAlternates { get; set; }

        /// <summary>
        /// Specifies the weight or boldness of the font.
        /// See CSS 3 'font-weight' property https://www.w3.org/TR/css-fonts-3/#propdef-font-weight
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight { get; set; }














    }


}
