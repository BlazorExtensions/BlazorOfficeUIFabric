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

    public enum FontSizeAdjustValues { Inherit, Initial, None, Unset };

    /// <summary>
    /// Allows you to expand or condense the widths for a normal, condensed, or expanded
    /// font face.
    /// See CSS 3 font-stretch property
    /// https://drafts.csswg.org/css-fonts-3/#propdef-font-stretch
    /// </summary>
    public enum FontStretch { Condensed, Expanded, ExtraCondensed, ExtraExpanded, Inherit, Initial, Normal, SemiCondensed, SemiExpanded, UltraCondensed, UltraExpanded, Unset };

    /// <summary>
    /// The font-style property allows normal, italic, or oblique faces to be selected.
    /// Italic forms are generally cursive in nature while oblique faces are typically
    /// sloped versions of the regular face. Oblique faces can be simulated by artificially
    /// sloping the glyphs of the regular face.
    /// See CSS 3 font-style property https://www.w3.org/TR/css-fonts-3/#propdef-font-style
    /// </summary>
    public enum FontStyle { Inherit, Initial, Italic, Normal, Oblique, Unset };

    public enum FontWeightValues { Bold, Bolder, Inherit, Initial, Lighter, Normal, The100, The200, The300, The400, The500, The600, The700, The800, The900, Unset };

    /// <summary>
    /// Aligns a flex container's lines within the flex container when there is extra space
    /// in the cross-axis, similar to how justify-content aligns individual items within the
    /// main-axis.
    /// </summary>
    public enum AlignContent { Center, FlexEnd, FlexStart, Inherit, Initial, SpaceAround, SpaceBetween, Stretch, Unset };

    /// <summary>
    /// Sets the default alignment in the cross axis for all of the flex container's items,
    /// including anonymous flex items, similarly to how justify-content aligns items along the
    /// main axis.
    /// </summary>
    public enum AlignItems { Baseline, Center, FlexEnd, FlexStart, Inherit, Initial, Stretch, Unset };

    /// <summary>
    /// Allows the default alignment to be overridden for individual flex items.
    /// </summary>
    public enum AlignSelf { Auto, Baseline, Center, FlexEnd, FlexStart, Inherit, Initial, Stretch, Unset };

    /// <summary>
    /// The animation-fill-mode CSS property specifies how a CSS animation should apply
    /// styles to its target before and after its execution.
    /// </summary>
    public enum AnimationFillMode { Backwards, Both, Forwards, Inherit, Initial, None, Unset };

    /// <summary>
    /// If a background-image is specified, this property determines
    /// whether that image's position is fixed within the viewport,
    /// or scrolls along with its containing block.
    /// See CSS 3 background-attachment property
    /// https://drafts.csswg.org/css-backgrounds-3/#the-background-attachment
    /// </summary>
    public enum BackgroundAttachment { Fixed, Inherit, Initial, Local, Scroll, Unset };

    /// <summary>
    /// The background-clip CSS property specifies if an element's background, whether a
    /// <color> or an <image>, extends underneath its border.
    ///
    /// \* Does not work in IE
    ///
    /// \* The `text` value is experimental and should not be used in production code.
    /// </summary>
    public enum BackgroundClip { BorderBox, ContentBox, Inherit, Initial, PaddingBox, Text, Unset };

    /// <summary>
    /// The CSS box-sizing property is used to alter the default CSS box model used to
    /// calculate width and height of the elements.
    /// </summary>
    public enum BoxSizing { BorderBox, ContentBox, Inherit, Initial, Unset };

    public enum ColumnCountValues { Auto, Inherit, Initial, Unset };

    public enum CssRule { Inherit, Initial, Unset };

    /// <summary>
    /// The flex-direction CSS property describes how flex items are placed in the flex
    /// container, by setting the direction of the flex container's main axis.
    /// </summary>
    public enum FlexDirection { Column, ColumnReverse, Inherit, Initial, Row, RowReverse, Unset };

    /// <summary>
    /// Specifies whether flex items are forced into a single line or can be wrapped onto
    /// multiple lines. If wrapping is allowed, this property also enables you to control
    /// the direction in which lines are stacked.
    /// See CSS flex-wrap property https://drafts.csswg.org/css-flexbox-1/#flex-wrap-property
    /// </summary>
    public enum FlexWrap { Inherit, Initial, Nowrap, Unset, Wrap, WrapReverse };

    /// <summary>
    /// Defines how the browser distributes space between and around flex items
    /// along the main-axis of their container.
    /// See CSS justify-content property
    /// https://www.w3.org/TR/css-flexbox-1/#justify-content-property
    /// </summary>
    public enum JustifyContent { Center, FlexEnd, FlexStart, Inherit, Initial, SpaceAround, SpaceBetween, SpaceEvenly, Unset };

    /// <summary>
    /// (Moz specific) font smoothing directive.
    ///
    /// (Webkit specific) font smoothing directive.
    /// </summary>
    public enum FontSmoothing { Antialiased, Grayscale, None, SubpixelAntialiased };

    /// <summary>
    /// The overflow property controls how extra content exceeding the bounding box of an
    /// element is rendered. It can be used in conjunction with an element that has a
    /// fixed width and height, to eliminate text-induced page distortion.
    ///
    /// Controls how extra content exceeding the x-axis of the bounding box of an element
    /// is rendered.
    ///
    /// Controls how extra content exceeding the y-axis of the bounding box of an element
    /// is rendered.
    /// </summary>
    public enum Overflow { Auto, Hidden, Inherit, Initial, Scroll, Unset, Visible };

    /// <summary>
    /// Specifies whether or not the browser should insert line breaks within words to
    /// prevent text from overflowing its content box. In contrast to word-break,
    /// overflow-wrap will only create a break if an entire word cannot be placed on its
    /// own line without overflowing.
    /// </summary>
    public enum OverflowWrap { BreakWord, Inherit, Initial, Normal, Unset };

    /// <summary>
    /// The position property controls the type of positioning used by an element within
    /// its parent elements. The effect of the position property depends on a lot of
    /// factors, for example the position property of parent elements.
    /// </summary>
    public enum Position { Absolute, Fixed, Inherit, Initial, Relative, Static, Sticky, Unset };

    /// <summary>
    /// The resize CSS sets whether an element is resizable, and if so, in which direction(s).
    /// </summary>
    public enum Resize { Block, Both, Horizontal, Inherit, Initial, Inline, None, Unset, Vertical };

    /// <summary>
    /// Defines the text selection behavior.
    /// </summary>
    public enum UserSelect { All, Auto, Contain, Inherit, Initial, None, Text, Unset };

    /// <summary>
    /// (Webkit specific) momentum scrolling on iOS devices
    /// </summary>
    public enum WebkitOverflowScrolling { Auto, Touch };

    /// <summary>
    /// Specifies the size of the font. Used to compute em and ex units.
    /// See CSS 3 font-size property https://www.w3.org/TR/css-fonts-3/#propdef-font-size
    ///
    /// Shorthand that sets the values of border-bottom-color,
    /// border-bottom-style, and border-bottom-width.
    ///
    /// Sets the width of an element's bottom border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    ///
    /// The border-image-width CSS property defines the offset to use for dividing the
    /// border image in nine parts, the top-left corner, central top edge, top-right-corner,
    /// central right edge, bottom-right corner, central bottom edge, bottom-left corner,
    /// and central right edge. They represent inward distance from the top, right, bottom,
    /// and left edges.
    ///
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's left border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the left
    /// border — border-left-width, border-left-style and border-left-color.
    ///
    /// Sets the width of an element's left border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    ///
    /// Defines how round the border's corners are.
    ///
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's right border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the
    /// right border — border-right-width, border-right-style and border-right-color.
    ///
    /// Sets the width of an element's right border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    ///
    /// Shorthand property that defines the border-width, border-style and border-color of
    /// an element's top border in a single declaration. Note that you can use the
    /// corresponding longhand properties to set specific individual properties of the top
    /// border — border-top-width, border-top-style and border-top-color.
    ///
    /// Sets the width of an element's top border. To set all four borders, use the
    /// border-width shorthand property which sets the values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    ///
    /// Sets the width of an element's four borders. This property can have from one to
    /// four values. This is a shorthand property for setting values simultaneously for
    /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
    ///
    /// This property specifies how far an absolutely positioned box's bottom margin edge
    /// is offset above the bottom edge of the box's containing block. For relatively
    /// positioned boxes, the offset is with respect to the bottom edges of the box itself
    /// (i.e., the box is given a position in the normal flow, then offset from that
    /// position according to these properties).
    ///
    /// Specifies the width of the rule between columns.
    ///
    /// Specifies the width of columns in multi-column elements.
    ///
    /// Shorthand for `flex-grow`, `flex-shrink`, and `flex-basis`.
    ///
    /// The flex-basis CSS property describes the initial main size of the flex item before
    /// any free space is distributed according to the flex factors described in the flex
    /// property (flex-grow and flex-shrink).
    ///
    /// Specifies the flex grow factor of a flex item.
    /// See CSS flex-grow property https://drafts.csswg.org/css-flexbox-1/#flex-grow-property
    ///
    /// Specifies the flex shrink factor of a flex item.
    /// See CSS flex-shrink property
    /// https://drafts.csswg.org/css-flexbox-1/#flex-shrink-property
    ///
    /// Sets the height of an element. The content area of the element height does not
    /// include the padding, border, and margin of the element.
    ///
    /// Sets the left position of an element relative to the nearest anscestor that is set
    /// to position absolute, relative, or fixed.
    ///
    /// Specifies the height of an inline block level element.
    /// See CSS 2.1 line-height property
    /// https://www.w3.org/TR/CSS21/visudet.html#propdef-line-height
    ///
    /// The margin property is shorthand to allow you to set all four margins of an element
    /// at once. Its equivalent longhand properties are margin-top, margin-right,
    /// margin-bottom and margin-left. Negative values are also allowed.
    ///
    /// margin-bottom sets the bottom margin of an element.
    ///
    /// margin-left sets the left margin of an element.
    ///
    /// margin-right sets the right margin of an element.
    ///
    /// margin-top sets the top margin of an element.
    ///
    /// This property sets the width of the mask box image, similar to the CSS
    /// border-image-width property.
    ///
    /// This property must not be used. It is no longer included in any standard or
    /// standard track specification, nor is it implemented in any browser. It is only
    /// used when the text-align-last property is set to size. It controls allowed
    /// adjustments of font-size to fit line content.
    ///
    /// Sets the maximum height for an element. It prevents the height of the element to
    /// exceed the specified value. If min-height is specified and is greater than
    /// max-height, max-height is overridden.
    ///
    /// Sets the maximum width for an element. It limits the width property to be larger
    /// than the value specified in max-width.
    ///
    /// Sets the minimum height for an element. It prevents the height of the element to
    /// be smaller than the specified value. The value of min-height overrides both
    /// max-height and height.
    ///
    /// Sets the minimum width of an element. It limits the width property to be not
    /// smaller than the value specified in min-width.
    ///
    /// Specifies the transparency of an element.
    /// See CSS 3 opacity property https://drafts.csswg.org/css-color-3/#opacity
    ///
    /// The padding optional CSS property sets the required padding space on one to four
    /// sides of an element. The padding area is the space between an element and its
    /// border. Negative values are not allowed but decimal values are permitted. The
    /// element size is treated as fixed, and the content of the element shifts toward the
    /// center as padding is increased. The padding property is a shorthand to avoid
    /// setting each side separately (padding-top, padding-right, padding-bottom,
    /// padding-left).
    ///
    /// The padding-bottom CSS property of an element sets the padding space required on
    /// the bottom of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-bottom values, negative values of
    /// padding-bottom are invalid.
    ///
    /// The padding-left CSS property of an element sets the padding space required on the
    /// left side of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-left values, negative values of
    /// padding-left are invalid.
    ///
    /// The padding-right CSS property of an element sets the padding space required on the
    /// right side of an element. The padding area is the space between the content of the
    /// element and its border. Contrary to margin-right values, negative values of
    /// padding-right are invalid.
    ///
    /// The padding-top CSS property of an element sets the padding space required on the
    /// top of an element. The padding area is the space between the content of the element
    /// and its border. Contrary to margin-top values, negative values of padding-top are
    /// invalid.
    ///
    /// Specifies the position an element in relation to the right side of the containing
    /// element.
    ///
    /// SVG: Specifies the width of the outline on the current object.
    /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeWidthProperty
    ///
    /// Specifies the line width for the overline text decoration.
    ///
    /// This property specifies how far an absolutely positioned box's top margin edge is
    /// offset below the top edge of the box's containing block. For relatively positioned
    /// boxes, the offset is with respect to the top edges of the box itself (i.e., the box
    /// is given a position in the normal flow, then offset from that position according to
    /// these properties).
    ///
    /// Specifies the width of the content area of an element. The content area of the element
    /// width does not include the padding, border, and margin of the element.
    ///
    /// Sets the initial zoom factor of a document defined by @viewport.
    /// See CSS zoom descriptor https://drafts.csswg.org/css-device-adapt/#zoom-desc
    /// </summary>

    public partial struct FontSizeAdjust
    {
        public FontSizeAdjust(FontSizeAdjustValues value)
        {
            this.Double = null;
            this.Enum = value;
        }

        public FontSizeAdjust(double value)
        {
            this.Double = value;
            this.Enum = null;
        }
        public double? Double { get; private set; }
        public FontSizeAdjustValues? Enum { get; private set; }

        public static implicit operator FontSizeAdjust(FontSizeAdjustValues value) => new FontSizeAdjust() { Enum = value };
        public static implicit operator FontSizeAdjust(double value) => new FontSizeAdjust() { Double = value };

        public static explicit operator string(FontSizeAdjust value) => value.ToString();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, RawConverter.Settings);
        }
        public bool IsNull => this.Double == null && this.Enum == null;
    }

    public partial struct FontWeight
    {

        public FontWeight(double value)
        {
            this.Double = value;
            this.Integer = null;
            this.Enum = null;
            this.String = null;
        }

        public FontWeight(int value)
        {
            this.Double = null;
            this.Integer = value;
            this.Enum = null;
            this.String = null;
        }
        public FontWeight(FontWeightValues value)
        {
            this.Enum = value;
            this.Double = null;
            this.Integer = null;
            this.String = null;
        }

        public FontWeight(string value)
        {
            this.String = value;
            this.Enum = null;
            this.Double = null;
            this.Integer = null;
        }

        public double? Double { get; internal set; }

        public FontWeightValues? Enum { get; internal set; }

        public long? Integer { get; internal set; }

        public string String { get; internal set; }

        public static implicit operator FontWeight(string value) => new FontWeight() { String = value };
        public static implicit operator FontWeight(FontWeightValues value) => new FontWeight() { Enum = value };
        public static implicit operator FontWeight(double value) => new FontWeight() { Double = value };
        public static implicit operator FontWeight(int value) => new FontWeight() { Integer = value };

        public static explicit operator string(FontWeight value) => value.ToString();

        public bool IsNull => this.Double == null && this.Integer == null && this.Enum == null && this.String == null;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, RawConverter.Settings);
        }

    }

    public partial struct ColumnCount
    {
        public ColumnCount(ColumnCountValues column)
        {
            this.Enum = column;
            this.Double = null;
        }

        public double? Double { get; private set; }
        public ColumnCountValues? Enum { get; private set; }

        public static implicit operator ColumnCount(ColumnCountValues value) => new ColumnCount() { Enum = value };
        public static implicit operator ColumnCount(double value) => new ColumnCount() { Double = value };

        public static explicit operator double(ColumnCount value) => value.Double ?? throw new InvalidCastException("The column count ist not and double instance");
        public static explicit operator ColumnCountValues(ColumnCount value) => value.Enum ?? throw new InvalidCastException("The column count ist not and ColumCountValues instance");
        public bool IsNull => this.Double == null && this.Enum == null;
    }

    public partial struct FillOpacity
    {
        public FillOpacity(double value)
        {
            this.Double = value;
            this.Enum = null;
        }
        public FillOpacity(CssRule value)
        {
            this.Double = null;
            this.Enum = value;
        }
        public double? Double { get; private set; }
        public CssRule? Enum { get; private set; }

        public static implicit operator FillOpacity(CssRule value) => new FillOpacity() { Enum = value };
        public static implicit operator FillOpacity(double value) => new FillOpacity() { Double = value };
        public bool IsNull => this.Double == null && this.Enum == null;
    }




}
