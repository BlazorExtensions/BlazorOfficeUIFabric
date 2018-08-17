// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do one of these: // using
// Blazor.Extensions.MergeStyles; // var icssRule = IcssRule.FromJson(jsonString); var
// icssPercentageRule = IcssPercentageRule.FromJson(jsonString); var icssPixelUnitRule =
// IcssPixelUnitRule.FromJson(jsonString); var iFontWeight = IFontWeight.FromJson(jsonString); var
// iRawFontStyle = IRawFontStyle.FromJson(jsonString); var iFontFace =
// IFontFace.FromJson(jsonString); var iRawStyleBase = IRawStyleBase.FromJson(jsonString);

namespace Blazor.Extensions.MergeStyles
{
    using Blazor.Extensions.MergeStyles.Extensions;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// All raw style properties.
    /// </summary>
    public partial class RawStyleBase : ReadOnlyDictionary<string, object>
    {
        private AlignContent? _alignContent;
        private AlignItems? _alignItems;
        private string _alignmentAdjust;
        private string _alignmentBaseline;
        private AlignSelf? _alignSelf;
        private string _animation;
        private string _animationDelay;
        private string _animationDirection;
        private string _animationDuration;
        private AnimationFillMode? _animationFillMode;
        private string _animationIterationCount;
        private string _animationName;
        private string _animationTimingFunction;
        private string _appearance;
        private string _backfaceVisibility;
        private string _background;
        private BackgroundAttachment? _backgroundAttachment;
        private string _backgroundBlendMode;
        private BackgroundClip? _backgroundClip;
        private string _backgroundColor;
        private string _backgroundComposite;
        private string _backgroundImage;
        private string _backgroundOrigin;
        private string _backgroundPosition;
        private string _backgroundRepeat;
        private string _backgroundSize;
        private CssValue? _border;
        private CssValue? _borderBottom;
        private string _borderBottomColor;
        private string _borderBottomLeftRadius;
        private string _borderBottomRightRadius;
        private CssValue? _zoom;
        private ColumnCount? _zIndex;
        private string _writingMode;
        private string _wrapMargin;
        private string _wrapFlow;
        private string _wordWrap;
        private string _wordSpacing;
        private string _wordBreak;
        private CssValue? _width;
        private FillOpacity? _widows;
        private string _whiteSpace;
        private WebkitOverflowScrolling? _webkitOverflowScrolling;
        private FontSmoothing? _webkitFontSmoothing;
        private string _voiceVolume;
        private string _borderBottomStyle;
        private CssValue? _borderBottomWidth;
        private string _borderCollapse;
        private string _borderColor;
        private string _borderCornerShape;
        private string _borderImageSource;
        private CssValue? _borderImageWidth;
        private CssValue? _borderLeft;
        private string _borderLeftColor;
        private string _borderLeftStyle;
        private CssValue? _borderLeftWidth;
        private CssValue? _borderRadius;
        private CssValue? _borderRight;
        private string _borderRightColor;
        private string _borderRightStyle;
        private CssValue? _borderRightWidth;
        private string _borderSpacing;
        private string _borderStyle;
        private CssValue? _borderTop;
        private string _borderTopColor;
        private string _borderTopLeftRadius;
        private string _borderTopRightRadius;
        private string _borderTopStyle;
        private CssValue? _borderTopWidth;
        private CssValue? _borderWidth;
        private CssValue? _bottom;
        private string _boxDecorationBreak;
        private string _boxShadow;
        private BoxSizing? _boxSizing;
        private string _breakAfter;
        private string _breakBefore;
        private string _breakInside;
        private string _clear;
        private string _clipRule;
        private string _color;
        private ColumnCount? _columnCount;
        private string _columnFill;
        private string _columnGap;
        private string _columnRule;
        private string _columnRuleColor;
        private CssValue? _columnRuleWidth;
        private string _columns;
        private string _columnSpan;
        private CssValue? _columnWidth;
        private string _content;
        private string _counterIncrement;
        private string _counterReset;
        private string _cue;
        private string _cueAfter;
        private string _cursor;
        private string _direction;
        private string _display;
        private string _fill;
        private FillOpacity? _fillOpacity;
        private string _fillRule;
        private string _filter;
        private CssValue? _flex;
        private CssValue? _flexBasis;
        private FlexDirection? _flexDirection;
        private string _flexFlow;
        private CssValue? _flexGrow;
        private CssValue? _flexShrink;
        private FlexWrap? _flexWrap;
        private string _float;
        private string _flowFrom;
        private string _font;
        private string _fontFamily;
        private string _fontKerning;
        private CssValue? _fontSize;
        private FontSizeAdjust? _fontSizeAdjust;
        private FontStretch? _fontStretch;
        private FontStyle? _fontStyle;
        private string _fontSynthesis;
        private string _fontVariant;
        private string _fontVariantAlternates;
        private FontWeight? _fontWeight;
        private string _gridArea;
        private string _gridColumn;
        private string _gridColumnEnd;
        private string _gridColumnStart;
        private string _gridRow;
        private string _gridRowEnd;
        private string _gridRowPosition;
        private string _gridTemplateAreas;
        private string _gridTemplateColumns;
        private string _gridTemplateRows;
        private CssValue? _height;
        private string _hyphenateLimitChars;
        private string _hyphenateLimitLines;
        private string _hyphenateLimitZone;
        private string _hyphens;
        private JustifyContent? _justifyContent;
        private CssValue? _left;
        private string _letterSpacing;
        private CssValue? _lineHeight;
        private string _listStyle;
        private string _listStyleImage;
        private string _listStylePosition;
        private string _listStyleType;
        private CssValue? _margin;
        private CssValue? _marginBottom;
        private CssValue? _marginLeft;
        private CssValue? _marginRight;
        private CssValue? _marginTop;
        private string _marqueeDirection;
        private string _marqueeStyle;
        private string _mask;
        private string _maskBorder;
        private string _maskBorderRepeat;
        private string _maskBorderSlice;
        private string _maskBorderSource;
        private CssValue? _maskBorderWidth;
        private string _maskClip;
        private string _maskOrigin;
        private CssValue? _maxFontSize;
        private CssValue? _maxHeight;
        private CssValue? _maxWidth;
        private CssValue? _minHeight;
        private CssValue? _minWidth;
        private FontSmoothing? _mozOsxFontSmoothing;
        private string _msHighContrastAdjust;
        private CssValue? _opacity;
        private FillOpacity? _order;
        private FillOpacity? _orphans;
        private CssValue? _outline;
        private string _outlineColor;
        private string _outlineOffset;
        private Overflow? _overflow;
        private string _overflowStyle;
        private OverflowWrap? _overflowWrap;
        private Overflow? _overflowX;
        private Overflow? _overflowY;
        private CssValue? _padding;
        private CssValue? _paddingBottom;
        private CssValue? _paddingLeft;
        private CssValue? _paddingRight;
        private CssValue? _paddingTop;
        private string _pageBreakAfter;
        private string _pageBreakBefore;
        private string _pageBreakInside;
        private string _pause;
        private string _pauseAfter;
        private string _pauseBefore;
        private string _perspective;
        private string _perspectiveOrigin;
        private string _pointerEvents;
        private Position? _position;
        private string _quotes;
        private string _regionFragment;
        private Resize? _resize;
        private string _restAfter;
        private string _restBefore;
        private CssValue? _right;
        private string _shapeImageThreshold;
        private string _shapeInside;
        private string _shapeMargin;
        private string _shapeOutside;
        private string _speak;
        private string _speakAs;
        private string _stroke;
        private FillOpacity? _strokeOpacity;
        private CssValue? _strokeWidth;
        private string _tableLayout;
        private string _tabSize;
        private string _textAlign;
        private string _textAlignLast;
        private string _textDecoration;
        private string _textDecorationColor;
        private string _textDecorationLine;
        private string _textDecorationSkip;
        private string _textDecorationStyle;
        private string _textEmphasis;
        private string _textEmphasisColor;
        private string _textEmphasisStyle;
        private string _textHeight;
        private string _textIndent;
        private string _textOverflow;
        private string _textOverline;
        private string _textOverlineColor;
        private string _textOverlineMode;
        private string _textOverlineStyle;
        private CssValue? _textOverlineWidth;
        private string _textRendering;
        private string _textShadow;
        private string _textTransform;
        private string _textUnderlinePosition;
        private string _textUnderlineStyle;
        private CssValue? _top;
        private string _touchAction;
        private string _transform;
        private string _transformOrigin;
        private string _transformOriginZ;
        private string _transition;
        private string _transformStyle;
        private string _transitionDelay;
        private string _transitionDuration;
        private string _transitionProperty;
        private string _transitionTimingFunction;
        private string _unicodeBidi;
        private string _userFocus;
        private string _userInput;
        private UserSelect? _userSelect;
        private string _verticalAlign;
        private string _visibility;
        private string _voiceBalance;
        private string _voiceDuration;
        private string _voiceFamily;
        private string _voicePitch;
        private string _voiceRange;
        private string _voiceRate;
        private string _voiceStress;
        private Type type;

        public RawStyleBase() : base(new Dictionary<string, object>())
        {
            this.type = this.GetType();
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (string.IsNullOrWhiteSpace(propertyName) || EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            //replace porpertyName with the json attribute 
            var prop = this.type.GetProperty(propertyName);
            if (prop.IsDefined(typeof(JsonPropertyAttribute), true))
            {
                var jsonProperty = prop.GetCustomAttribute<JsonPropertyAttribute>();
                propertyName = jsonProperty.PropertyName;
            }
          

            //Remove the value if default
            if (value == default && this.Dictionary.ContainsKey(propertyName))
            {
                this.Dictionary.Remove(propertyName);
            }
            //add or update the value
            else
            {
                this.Dictionary[propertyName] = value;
            }
            return true;

        }

        public static RawStyleBase FromJson(string json) => JsonConvert.DeserializeObject<RawStyleBase>(json, Blazor.Extensions.MergeStyles.RawConverter.Settings);

        /// <summary>
        /// Aligns a flex container's lines within the flex container when there is extra space in
        /// the cross-axis, similar to how justify-content aligns individual items within the main-axis.
        /// </summary>
        [JsonProperty("alignContent", NullValueHandling = NullValueHandling.Ignore)]
        public AlignContent? AlignContent
        {
            get { return this._alignContent; }
            set { this.SetProperty(ref this._alignContent, value); }
        }

        /// <summary>
        /// Sets the default alignment in the cross axis for all of the flex container's items,
        /// including anonymous flex items, similarly to how justify-content aligns items along the
        /// main axis.
        /// </summary>
        [JsonProperty("alignItems", NullValueHandling = NullValueHandling.Ignore)]
        public AlignItems? AlignItems
        {
            get { return this._alignItems; }
            set { this.SetProperty(ref this._alignItems, value); }
        }

        /// <summary>
        /// This property allows precise alignment of elements, such as graphics, that do not have a
        /// baseline-table or lack the desired baseline in their baseline-table. With the
        /// alignment-adjust property, the position of the baseline identified by the
        /// alignment-baseline can be explicitly determined. It also determines precisely the
        /// alignment point for each glyph within a textual element.
        /// </summary>
        [JsonProperty("alignmentAdjust", NullValueHandling = NullValueHandling.Ignore)]
        public string AlignmentAdjust
        {
            get { return this._alignmentAdjust; }
            set { this.SetProperty(ref this._alignmentAdjust, value); }
        }

        /// <summary>
        /// Specifies how an object is aligned with respect to its parent. This property specifies
        /// which baseline of this element is to be aligned with the corresponding baseline of the
        /// parent. For example, this allows alphabetic baselines in Roman text to stay aligned
        /// across font size changes. It defaults to the baseline with the same name as the computed
        /// value of the alignment-baseline property.
        /// </summary>
        [JsonProperty("alignmentBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public string AlignmentBaseline
        {
            get { return this._alignmentBaseline; }
            set { this.SetProperty(ref this._alignmentBaseline, value); }
        }

        /// <summary>
        /// Allows the default alignment to be overridden for individual flex items.
        /// </summary>
        [JsonProperty("alignSelf", NullValueHandling = NullValueHandling.Ignore)]
        public AlignSelf? AlignSelf
        {
            get { return this._alignSelf; }
            set { this.SetProperty(ref this._alignSelf, value); }
        }

        /// <summary>
        /// The animation CSS property is a shorthand property for the various animation properties:
        /// `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`,
        /// `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and `animation-play-state`.
        /// </summary>
        [JsonProperty("animation", NullValueHandling = NullValueHandling.Ignore)]
        public string Animation
        {
            get { return this._animation; }
            set { this.SetProperty(ref this._animation, value); }
        }

        /// <summary>
        /// Defines a length of time to elapse before an animation starts, allowing an animation to
        /// begin execution some time after it is applied.
        /// </summary>
        [JsonProperty("animationDelay", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationDelay
        {
            get { return this._animationDelay; }
            set { this.SetProperty(ref this._animationDelay, value); }
        }

        /// <summary>
        /// Defines whether an animation should run in reverse on some or all cycles.
        /// </summary>
        [JsonProperty("animationDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationDirection
        {
            get { return this._animationDirection; }
            set { this.SetProperty(ref this._animationDirection, value); }
        }

        /// <summary>
        /// Specifies the length an animation takes to finish. Default value is 0, meaning there will
        /// be no animation.
        /// </summary>
        [JsonProperty("animationDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationDuration
        {
            get { return this._animationDuration; }
            set { this.SetProperty(ref this._animationDuration, value); }
        }

        /// <summary>
        /// The animation-fill-mode CSS property specifies how a CSS animation should apply styles to
        /// its target before and after its execution.
        /// </summary>
        [JsonProperty("animationFillMode", NullValueHandling = NullValueHandling.Ignore)]
        public AnimationFillMode? AnimationFillMode
        {
            get { return this._animationFillMode; }
            set { this.SetProperty(ref this._animationFillMode, value); }
        }

        /// <summary>
        /// Specifies how many times an animation cycle should play.
        /// </summary>
        [JsonProperty("animationIterationCount", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationIterationCount
        {
            get { return this._animationIterationCount; }
            set { this.SetProperty(ref this._animationIterationCount, value); }
        }

        /// <summary>
        /// Defines the list of animations that apply to the element.
        /// </summary>
        [JsonProperty("animationName", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationName
        {
            get { return this._animationName; }
            set { this.SetProperty(ref this._animationName, value); }
        }

        /// <summary>
        /// Defines whether an animation is running or paused.
        /// </summary>
        [JsonProperty("animationPlayState", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationPlayState { get; set; }

        /// <summary>
        /// The animation-timing-function specifies the speed curve of an animation.
        /// </summary>
        [JsonProperty("animationTimingFunction", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationTimingFunction
        {
            get { return this._animationTimingFunction; }
            set { this.SetProperty(ref this._animationTimingFunction, value); }
        }

        /// <summary>
        /// Allows changing the style of any element to platform-based interface elements or vice versa.
        /// </summary>
        [JsonProperty("appearance", NullValueHandling = NullValueHandling.Ignore)]
        public string Appearance
        {
            get { return this._appearance; }
            set { this.SetProperty(ref this._appearance, value); }
        }

        /// <summary>
        /// Determines whether or not the “back” side of a transformed element is visible when facing
        /// the viewer.
        /// </summary>
        [JsonProperty("backfaceVisibility", NullValueHandling = NullValueHandling.Ignore)]
        public string BackfaceVisibility
        {
            get { return this._backfaceVisibility; }
            set { this.SetProperty(ref this._backfaceVisibility, value); }
        }

        /// <summary>
        /// Shorthand property to set the values for one or more of: background-clip,
        /// background-color, background-image, background-origin, background-position,
        /// background-repeat, background-size, and background-attachment.
        /// </summary>
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background
        {
            get { return this._background; }
            set { this.SetProperty(ref this._background, value); }
        }

        /// <summary>
        /// If a background-image is specified, this property determines whether that image's
        /// position is fixed within the viewport, or scrolls along with its containing block. See
        /// CSS 3 background-attachment property https://drafts.csswg.org/css-backgrounds-3/#the-background-attachment
        /// </summary>
        [JsonProperty("backgroundAttachment", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundAttachment? BackgroundAttachment
        {
            get { return this._backgroundAttachment; }
            set { this.SetProperty(ref this._backgroundAttachment, value); }
        }

        /// <summary>
        /// This property describes how the element's background images should blend with each other
        /// and the element's background color. The value is a list of blend modes that corresponds
        /// to each background image. Each element in the list will apply to the corresponding
        /// element of background-image. If a property doesn’t have enough comma-separated values to
        /// match the number of layers, the UA must calculate its used value by repeating the list of
        /// values until there are enough.
        /// </summary>
        [JsonProperty("backgroundBlendMode", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundBlendMode
        {
            get { return this._backgroundBlendMode; }
            set { this.SetProperty(ref this._backgroundBlendMode, value); }
        }

        /// <summary> The background-clip CSS property specifies if an element's background, whether
        /// a <color> or an <image>, extends underneath its border. /// \* Does not work in IE /// \*
        /// The `text` value is experimental and should not be used in production code. </summary>
        [JsonProperty("backgroundClip", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundClip? BackgroundClip
        {
            get { return this._backgroundClip; }
            set { this.SetProperty(ref this._backgroundClip, value); }
        }

        /// <summary>
        /// Sets the background color of an element.
        /// </summary>
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this.SetProperty(ref this._backgroundColor, value); }
        }

        /// <summary>
        /// Sets a compositing style for background images and colors.
        /// </summary>
        [JsonProperty("backgroundComposite", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundComposite
        {
            get { return this._backgroundComposite; }
            set { this.SetProperty(ref this._backgroundComposite, value); }
        }

        /// <summary>
        /// Applies one or more background images to an element. These can be any valid CSS image,
        /// including url() paths to image files or CSS gradients.
        /// </summary>
        [JsonProperty("backgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundImage
        {
            get { return this._backgroundImage; }
            set { this.SetProperty(ref this._backgroundImage, value); }
        }

        /// <summary>
        /// Specifies what the background-position property is relative to.
        /// </summary>
        [JsonProperty("backgroundOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundOrigin
        {
            get { return this._backgroundOrigin; }
            set { this.SetProperty(ref this._backgroundOrigin, value); }
        }

        /// <summary>
        /// Sets the position of a background image.
        /// </summary>
        [JsonProperty("backgroundPosition", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundPosition
        {
            get { return this._backgroundPosition; }
            set { this.SetProperty(ref this._backgroundPosition, value); }
        }

        /// <summary>
        /// Background-repeat defines if and how background images will be repeated after they have
        /// been sized and positioned
        /// </summary>
        [JsonProperty("backgroundRepeat", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundRepeat
        {
            get { return this._backgroundRepeat; }
            set { this.SetProperty(ref this._backgroundRepeat, value); }
        }

        /// <summary>
        /// Sets the size of background images
        /// </summary>
        [JsonProperty("backgroundSize", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundSize
        {
            get { return this._backgroundSize; }
            set { this.SetProperty(ref this._backgroundSize, value); }
        }

        /// <summary>
        /// Shorthand property that defines the different properties of all four sides of an
        /// element's border in a single declaration. It can be used to set border-width,
        /// border-style and border-color, or a subset of these.
        /// </summary>
        [JsonProperty("border", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Border
        {
            get { return this._border; }
            set { this.SetProperty(ref this._border, value); }
        }

        /// <summary>
        /// Shorthand that sets the values of border-bottom-color, border-bottom-style, and border-bottom-width.
        /// </summary>
        [JsonProperty("borderBottom", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderBottom
        {
            get { return this._borderBottom; }
            set { this.SetProperty(ref this._borderBottom, value); }
        }

        /// <summary>
        /// Sets the color of the bottom border of an element.
        /// </summary>
        [JsonProperty("borderBottomColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomColor
        {
            get { return this._borderBottomColor; }
            set { this.SetProperty(ref this._borderBottomColor, value); }
        }

        /// <summary>
        /// Defines the shape of the border of the bottom-left corner.
        /// </summary>
        [JsonProperty("borderBottomLeftRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomLeftRadius
        {
            get { return this._borderBottomLeftRadius; }
            set { this.SetProperty(ref this._borderBottomLeftRadius, value); }
        }

        /// <summary>
        /// Defines the shape of the border of the bottom-right corner.
        /// </summary>
        [JsonProperty("borderBottomRightRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomRightRadius
        {
            get { return this._borderBottomRightRadius; }
            set { this.SetProperty(ref this._borderBottomRightRadius, value); }
        }

        /// <summary>
        /// Sets the line style of the bottom border of a box.
        /// </summary>
        [JsonProperty("borderBottomStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderBottomStyle
        {
            get { return this._borderBottomStyle; }
            set { this.SetProperty(ref this._borderBottomStyle, value); }
        }

        /// <summary>
        /// Sets the width of an element's bottom border. To set all four borders, use the
        /// border-width shorthand property which sets the values simultaneously for
        /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
        /// </summary>
        [JsonProperty("borderBottomWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderBottomWidth
        {
            get { return this._borderBottomWidth; }
            set { this.SetProperty(ref this._borderBottomWidth, value); }
        }

        /// <summary>
        /// Border-collapse can be used for collapsing the borders between table cells
        /// </summary>
        [JsonProperty("borderCollapse", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderCollapse
        {
            get { return this._borderCollapse; }
            set { this.SetProperty(ref this._borderCollapse, value); }
        }

        /// <summary>
        /// The CSS border-color property sets the color of an element's four borders. This property
        /// can have from one to four values, made up of the elementary properties: •
        /// border-top-color • border-right-color • border-bottom-color • border-left-color The
        /// default color is the currentColor of each of these values. If you provide one value, it
        /// sets the color for the element. Two values set the horizontal and vertical values,
        /// respectively. Providing three values sets the top, vertical, and bottom values, in that
        /// order. Four values set all for sides: top, right, bottom, and left, in that order.
        /// </summary>
        [JsonProperty("borderColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor
        {
            get { return this._borderColor; }
            set { this.SetProperty(ref this._borderColor, value); }
        }

        /// <summary>
        /// Specifies different corner clipping effects, such as scoop (inner curves), bevel
        /// (straight cuts) or notch (cut-off rectangles). Works along with border-radius to specify
        /// the size of each corner effect.
        /// </summary>
        [JsonProperty("borderCornerShape", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderCornerShape
        {
            get { return this._borderCornerShape; }
            set { this.SetProperty(ref this._borderCornerShape, value); }
        }

        /// <summary>
        /// The property border-image-source is used to set the image to be used instead of the
        /// border style. If this is set to none the border-style is used instead.
        /// </summary>
        [JsonProperty("borderImageSource", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderImageSource
        {
            get { return this._borderImageSource; }
            set { this.SetProperty(ref this._borderImageSource, value); }
        }

        /// <summary>
        /// The border-image-width CSS property defines the offset to use for dividing the border
        /// image in nine parts, the top-left corner, central top edge, top-right-corner, central
        /// right edge, bottom-right corner, central bottom edge, bottom-left corner, and central
        /// right edge. They represent inward distance from the top, right, bottom, and left edges.
        /// </summary>
        [JsonProperty("borderImageWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderImageWidth
        {
            get { return this._borderImageWidth; }
            set { this.SetProperty(ref this._borderImageWidth, value); }
        }

        /// <summary>
        /// Shorthand property that defines the border-width, border-style and border-color of an
        /// element's left border in a single declaration. Note that you can use the corresponding
        /// longhand properties to set specific individual properties of the left border —
        /// border-left-width, border-left-style and border-left-color.
        /// </summary>
        [JsonProperty("borderLeft", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderLeft
        {
            get { return this._borderLeft; }
            set { this.SetProperty(ref this._borderLeft, value); }
        }

        /// <summary>
        /// The CSS border-left-color property sets the color of an element's left border. This page
        /// explains the border-left-color value, but often you will find it more convenient to fix
        /// the border's left color as part of a shorthand set, either border-left or border-color.
        /// Colors can be defined several ways. For more information, see Usage.
        /// </summary>
        [JsonProperty("borderLeftColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderLeftColor
        {
            get { return this._borderLeftColor; }
            set { this.SetProperty(ref this._borderLeftColor, value); }
        }

        /// <summary>
        /// Sets the style of an element's left border. To set all four borders, use the shorthand
        /// property, border-style. Otherwise, you can set the borders individually with
        /// border-top-style, border-right-style, border-bottom-style, border-left-style.
        /// </summary>
        [JsonProperty("borderLeftStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderLeftStyle
        {
            get { return this._borderLeftStyle; }
            set { this.SetProperty(ref this._borderLeftStyle, value); }
        }

        /// <summary>
        /// Sets the width of an element's left border. To set all four borders, use the border-width
        /// shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        /// </summary>
        [JsonProperty("borderLeftWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderLeftWidth
        {
            get { return this._borderLeftWidth; }
            set { this.SetProperty(ref this._borderLeftWidth, value); }
        }

        /// <summary>
        /// Defines how round the border's corners are.
        /// </summary>
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderRadius
        {
            get { return this._borderRadius; }
            set { this.SetProperty(ref this._borderRadius, value); }
        }

        /// <summary>
        /// Shorthand property that defines the border-width, border-style and border-color of an
        /// element's right border in a single declaration. Note that you can use the corresponding
        /// longhand properties to set specific individual properties of the right border —
        /// border-right-width, border-right-style and border-right-color.
        /// </summary>
        [JsonProperty("borderRight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderRight
        {
            get { return this._borderRight; }
            set { this.SetProperty(ref this._borderRight, value); }
        }

        /// <summary>
        /// Sets the color of an element's right border. This page explains the border-right-color
        /// value, but often you will find it more convenient to fix the border's right color as part
        /// of a shorthand set, either border-right or border-color. Colors can be defined several
        /// ways. For more information, see Usage.
        /// </summary>
        [JsonProperty("borderRightColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderRightColor
        {
            get { return this._borderRightColor; }
            set { this.SetProperty(ref this._borderRightColor, value); }
        }

        /// <summary>
        /// Sets the style of an element's right border. To set all four borders, use the shorthand
        /// property, border-style. Otherwise, you can set the borders individually with
        /// border-top-style, border-right-style, border-bottom-style, border-left-style.
        /// </summary>
        [JsonProperty("borderRightStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderRightStyle
        {
            get { return this._borderRightStyle; }
            set { this.SetProperty(ref this._borderRightStyle, value); }
        }

        /// <summary>
        /// Sets the width of an element's right border. To set all four borders, use the
        /// border-width shorthand property which sets the values simultaneously for
        /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
        /// </summary>
        [JsonProperty("borderRightWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderRightWidth
        {
            get { return this._borderRightWidth; }
            set { this.SetProperty(ref this._borderRightWidth, value); }
        }

        /// <summary>
        /// Specifies the distance between the borders of adjacent cells.
        /// </summary>
        [JsonProperty("borderSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderSpacing
        {
            get { return this._borderSpacing; }
            set { this.SetProperty(ref this._borderSpacing, value); }
        }

        /// <summary>
        /// Sets the style of an element's four borders. This property can have from one to four
        /// values. With only one value, the value will be applied to all four borders; otherwise,
        /// this works as a shorthand property for each of border-top-style, border-right-style,
        /// border-bottom-style, border-left-style, where each border style may be assigned a
        /// separate value.
        /// </summary>
        [JsonProperty("borderStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderStyle
        {
            get { return this._borderStyle; }
            set { this.SetProperty(ref this._borderStyle, value); }
        }

        /// <summary>
        /// Shorthand property that defines the border-width, border-style and border-color of an
        /// element's top border in a single declaration. Note that you can use the corresponding
        /// longhand properties to set specific individual properties of the top border —
        /// border-top-width, border-top-style and border-top-color.
        /// </summary>
        [JsonProperty("borderTop", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderTop
        {
            get { return this._borderTop; }
            set { this.SetProperty(ref this._borderTop, value); }
        }

        /// <summary>
        /// Sets the color of an element's top border. This page explains the border-top-color value,
        /// but often you will find it more convenient to fix the border's top color as part of a
        /// shorthand set, either border-top or border-color. Colors can be defined several ways. For
        /// more information, see Usage.
        /// </summary>
        [JsonProperty("borderTopColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopColor
        {
            get { return this._borderTopColor; }
            set { this.SetProperty(ref this._borderTopColor, value); }
        }

        /// <summary>
        /// Sets the rounding of the top-left corner of the element.
        /// </summary>
        [JsonProperty("borderTopLeftRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopLeftRadius
        {
            get { return this._borderTopLeftRadius; }
            set { this.SetProperty(ref this._borderTopLeftRadius, value); }
        }

        /// <summary>
        /// Sets the rounding of the top-right corner of the element.
        /// </summary>
        [JsonProperty("borderTopRightRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopRightRadius
        {
            get { return this._borderTopRightRadius; }
            set { this.SetProperty(ref this._borderTopRightRadius, value); }
        }

        /// <summary>
        /// Sets the style of an element's top border. To set all four borders, use the shorthand
        /// property, border-style. Otherwise, you can set the borders individually with
        /// border-top-style, border-right-style, border-bottom-style, border-left-style.
        /// </summary>
        [JsonProperty("borderTopStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderTopStyle
        {
            get { return this._borderTopStyle; }
            set { this.SetProperty(ref this._borderTopStyle, value); }
        }

        /// <summary>
        /// Sets the width of an element's top border. To set all four borders, use the border-width
        /// shorthand property which sets the values simultaneously for border-top-width,
        /// border-right-width, border-bottom-width, and border-left-width.
        /// </summary>
        [JsonProperty("borderTopWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderTopWidth
        {
            get { return this._borderTopWidth; }
            set { this.SetProperty(ref this._borderTopWidth, value); }
        }

        /// <summary>
        /// Sets the width of an element's four borders. This property can have from one to four
        /// values. This is a shorthand property for setting values simultaneously for
        /// border-top-width, border-right-width, border-bottom-width, and border-left-width.
        /// </summary>
        [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? BorderWidth
        {
            get { return this._borderWidth; }
            set { this.SetProperty(ref this._borderWidth, value); }
        }

        /// <summary>
        /// This property specifies how far an absolutely positioned box's bottom margin edge is
        /// offset above the bottom edge of the box's containing block. For relatively positioned
        /// boxes, the offset is with respect to the bottom edges of the box itself (i.e., the box is
        /// given a position in the normal flow, then offset from that position according to these properties).
        /// </summary>
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Bottom
        {
            get { return this._bottom; }
            set { this.SetProperty(ref this._bottom, value); }
        }

        /// <summary>
        /// Breaks a box into fragments creating new borders, padding and repeating backgrounds or
        /// lets it stay as a continuous box on a page break, column break, or, for inline elements,
        /// at a line break.
        /// </summary>
        [JsonProperty("boxDecorationBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string BoxDecorationBreak
        {
            get { return this._boxDecorationBreak; }
            set { this.SetProperty(ref this._boxDecorationBreak, value); }
        }

        /// <summary>
        /// Cast a drop shadow from the frame of almost any element.
        /// MDN: https://developer.mozilla.org/en-US/docs/Web/CSS/box-shadow
        /// </summary>
        [JsonProperty("boxShadow", NullValueHandling = NullValueHandling.Ignore)]
        public string BoxShadow
        {
            get { return this._boxShadow; }
            set { this.SetProperty(ref this._boxShadow, value); }
        }

        /// <summary>
        /// The CSS box-sizing property is used to alter the default CSS box model used to calculate
        /// width and height of the elements.
        /// </summary>
        [JsonProperty("boxSizing", NullValueHandling = NullValueHandling.Ignore)]
        public BoxSizing? BoxSizing
        {
            get { return this._boxSizing; }
            set { this.SetProperty(ref this._boxSizing, value); }
        }

        /// <summary>
        /// The CSS break-after property allows you to force a break on multi-column layouts. More
        /// specifically, it allows you to force a break after an element. It allows you to determine
        /// if a break should occur, and what type of break it should be. The break-after CSS
        /// property describes how the page, column or region break behaves after the generated box.
        /// If there is no generated box, the property is ignored.
        /// </summary>
        [JsonProperty("breakAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string BreakAfter
        {
            get { return this._breakAfter; }
            set { this.SetProperty(ref this._breakAfter, value); }
        }

        /// <summary>
        /// Control page/column/region breaks that fall above a block of content
        /// </summary>
        [JsonProperty("breakBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string BreakBefore
        {
            get { return this._breakBefore; }
            set { this.SetProperty(ref this._breakBefore, value); }
        }

        /// <summary>
        /// Control page/column/region breaks that fall within a block of content
        /// </summary>
        [JsonProperty("breakInside", NullValueHandling = NullValueHandling.Ignore)]
        public string BreakInside
        {
            get { return this._breakInside; }
            set { this.SetProperty(ref this._breakInside, value); }
        }

        /// <summary>
        /// The clear CSS property specifies if an element can be positioned next to or must be
        /// positioned below the floating elements that precede it in the markup.
        /// </summary>
        [JsonProperty("clear", NullValueHandling = NullValueHandling.Ignore)]
        public string Clear
        {
            get { return this._clear; }
            set { this.SetProperty(ref this._clear, value); }
        }

        /// <summary>
        /// Clipping crops an graphic, so that only a portion of the graphic is rendered, or filled.
        /// This clip-rule property, when used with the clip-path property, defines which clip rule,
        /// or algorithm, to use when filling the different parts of a graphics.
        /// </summary>
        [JsonProperty("clipRule", NullValueHandling = NullValueHandling.Ignore)]
        public string ClipRule
        {
            get { return this._clipRule; }
            set { this.SetProperty(ref this._clipRule, value); }
        }

        /// <summary>
        /// The color property sets the color of an element's foreground content (usually text),
        /// accepting any standard CSS color from keywords and hex values to RGB(a) and HSL(a).
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color
        {
            get { return this._color; }
            set { this.SetProperty(ref this._color, value); }
        }

        /// <summary>
        /// Describes the number of columns of the element. See CSS 3 column-count property https://www.w3.org/TR/css3-multicol/#cc
        /// </summary>
        [JsonProperty("columnCount", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnCount? ColumnCount
        {
            get { return this._columnCount; }
            set { this.SetProperty(ref this._columnCount, value); }
        }

        /// <summary>
        /// Specifies how to fill columns (balanced or sequential).
        /// </summary>
        [JsonProperty("columnFill", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnFill
        {
            get { return this._columnFill; }
            set { this.SetProperty(ref this._columnFill, value); }
        }

        /// <summary>
        /// The column-gap property controls the width of the gap between columns in multi-column elements.
        /// </summary>
        [JsonProperty("columnGap", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnGap
        {
            get { return this._columnGap; }
            set { this.SetProperty(ref this._columnGap, value); }
        }

        /// <summary>
        /// Sets the width, style, and color of the rule between columns.
        /// </summary>
        [JsonProperty("columnRule", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnRule
        {
            get { return this._columnRule; }
            set { this.SetProperty(ref this._columnRule, value); }
        }

        /// <summary>
        /// Specifies the color of the rule between columns.
        /// </summary>
        [JsonProperty("columnRuleColor", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnRuleColor
        {
            get { return this._columnRuleColor; }
            set { this.SetProperty(ref this._columnRuleColor, value); }
        }

        /// <summary>
        /// Specifies the width of the rule between columns.
        /// </summary>
        [JsonProperty("columnRuleWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? ColumnRuleWidth
        {
            get { return this._columnRuleWidth; }
            set { this.SetProperty(ref this._columnRuleWidth, value); }
        }

        /// <summary>
        /// This property is a shorthand property for setting column-width and/or column-count.
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public string Columns
        {
            get { return this._columns; }
            set { this.SetProperty(ref this._columns, value); }
        }

        /// <summary>
        /// The column-span CSS property makes it possible for an element to span across all columns
        /// when its value is set to all. An element that spans more than one column is called a
        /// spanning element.
        /// </summary>
        [JsonProperty("columnSpan", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnSpan
        {
            get { return this._columnSpan; }
            set { this.SetProperty(ref this._columnSpan, value); }
        }

        /// <summary>
        /// Specifies the width of columns in multi-column elements.
        /// </summary>
        [JsonProperty("columnWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? ColumnWidth
        {
            get { return this._columnWidth; }
            set { this.SetProperty(ref this._columnWidth, value); }
        }

        /// <summary>
        /// Content for pseudo selectors.
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content
        {
            get { return this._content; }
            set { this.SetProperty(ref this._content, value); }
        }

        /// <summary>
        /// The counter-increment property accepts one or more names of counters (identifiers), each
        /// one optionally followed by an integer which specifies the value by which the counter
        /// should be incremented (e.g. if the value is 2, the counter increases by 2 each time it is invoked).
        /// </summary>
        [JsonProperty("counterIncrement", NullValueHandling = NullValueHandling.Ignore)]
        public string CounterIncrement
        {
            get { return this._counterIncrement; }
            set { this.SetProperty(ref this._counterIncrement, value); }
        }

        /// <summary>
        /// The counter-reset property contains a list of one or more names of counters, each one
        /// optionally followed by an integer (otherwise, the integer defaults to 0.) Each time the
        /// given element is invoked, the counters specified by the property are set to the given integer.
        /// </summary>
        [JsonProperty("counterReset", NullValueHandling = NullValueHandling.Ignore)]
        public string CounterReset
        {
            get { return this._counterReset; }
            set { this.SetProperty(ref this._counterReset, value); }
        }

        /// <summary>
        /// The cue property specifies sound files (known as an "auditory icon") to be played by
        /// speech media agents before and after presenting an element's content; if only one file is
        /// specified, it is played both before and after. The volume at which the file(s) should be
        /// played, relative to the volume of the main element, may also be specified. The icon files
        /// may also be set separately with the cue-before and cue-after properties.
        /// </summary>
        [JsonProperty("cue", NullValueHandling = NullValueHandling.Ignore)]
        public string Cue
        {
            get { return this._cue; }
            set { this.SetProperty(ref this._cue, value); }
        }

        /// <summary>
        /// The cue-after property specifies a sound file (known as an "auditory icon") to be played
        /// by speech media agents after presenting an element's content; the volume at which the
        /// file should be played may also be specified. The shorthand property cue sets cue sounds
        /// for both before and after the element is presented.
        /// </summary>
        [JsonProperty("cueAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string CueAfter
        {
            get { return this._cueAfter; }
            set { this.SetProperty(ref this._cueAfter, value); }
        }

        /// <summary>
        /// Specifies the mouse cursor displayed when the mouse pointer is over an element.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor
        {
            get { return this._cursor; }
            set { this.SetProperty(ref this._cursor, value); }
        }

        /// <summary>
        /// The direction CSS property specifies the text direction/writing direction. The rtl is
        /// used for Hebrew or Arabic text, the ltr is for other languages.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction
        {
            get { return this._direction; }
            set { this.SetProperty(ref this._direction, value); }
        }

        /// <summary>
        /// This property specifies the type of rendering box used for an element. It is a shorthand
        /// property for many other display properties.
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public string Display
        {
            get { return this._display; }
            set { this.SetProperty(ref this._display, value); }
        }

        /// <summary>
        /// The ‘fill’ property paints the interior of the given graphical element. The area to be
        /// painted consists of any areas inside the outline of the shape. To determine the inside of
        /// the shape, all subpaths are considered, and the interior is determined according to the
        /// rules associated with the current value of the ‘fill-rule’ property. The zero-width
        /// geometric outline of a shape is included in the area to be painted.
        /// </summary>
        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public string Fill
        {
            get { return this._fill; }
            set { this.SetProperty(ref this._fill, value); }
        }

        /// <summary>
        /// SVG: Specifies the opacity of the color or the content the current object is filled with.
        /// See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#FillOpacityProperty
        /// </summary>
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public FillOpacity? FillOpacity
        {
            get { return this._fillOpacity; }
            set { this.SetProperty(ref this._fillOpacity, value); }
        }

        /// <summary>
        /// The ‘fill-rule’ property indicates the algorithm which is to be used to determine what
        /// parts of the canvas are included inside the shape. For a simple, non-intersecting path,
        /// it is intuitively clear what region lies "inside"; however, for a more complex path, such
        /// as a path that intersects itself or where one subpath encloses another, the
        /// interpretation of "inside" is not so obvious. The ‘fill-rule’ property provides two
        /// options for how the inside of a shape is determined:
        /// </summary>
        [JsonProperty("fillRule", NullValueHandling = NullValueHandling.Ignore)]
        public string FillRule
        {
            get { return this._fillRule; }
            set { this.SetProperty(ref this._fillRule, value); }
        }

        /// <summary>
        /// Applies various image processing effects. This property is largely unsupported. See
        /// Compatibility section for more information.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter
        {
            get { return this._filter; }
            set { this.SetProperty(ref this._filter, value); }
        }

        /// <summary>
        /// Shorthand for `flex-grow`, `flex-shrink`, and `flex-basis`.
        /// </summary>
        [JsonProperty("flex", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Flex
        {
            get { return this._flex; }
            set { this.SetProperty(ref this._flex, value); }
        }

        /// <summary>
        /// The flex-basis CSS property describes the initial main size of the flex item before any
        /// free space is distributed according to the flex factors described in the flex property
        /// (flex-grow and flex-shrink).
        /// </summary>
        [JsonProperty("flexBasis", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? FlexBasis
        {
            get { return this._flexBasis; }
            set { this.SetProperty(ref this._flexBasis, value); }
        }

        /// <summary>
        /// The flex-direction CSS property describes how flex items are placed in the flex
        /// container, by setting the direction of the flex container's main axis.
        /// </summary>
        [JsonProperty("flexDirection", NullValueHandling = NullValueHandling.Ignore)]
        public FlexDirection? FlexDirection
        {
            get { return this._flexDirection; }
            set { this.SetProperty(ref this._flexDirection, value); }
        }

        /// <summary>
        /// The flex-flow CSS property defines the flex container's main and cross axis. It is a
        /// shorthand property for the flex-direction and flex-wrap properties.
        /// </summary>
        [JsonProperty("flexFlow", NullValueHandling = NullValueHandling.Ignore)]
        public string FlexFlow
        {
            get { return this._flexFlow; }
            set { this.SetProperty(ref this._flexFlow, value); }
        }

        /// <summary>
        /// Specifies the flex grow factor of a flex item. See CSS flex-grow property https://drafts.csswg.org/css-flexbox-1/#flex-grow-property
        /// </summary>
        [JsonProperty("flexGrow", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? FlexGrow
        {
            get { return this._flexGrow; }
            set { this.SetProperty(ref this._flexGrow, value); }
        }

        /// <summary>
        /// Specifies the flex shrink factor of a flex item. See CSS flex-shrink property https://drafts.csswg.org/css-flexbox-1/#flex-shrink-property
        /// </summary>
        [JsonProperty("flexShrink", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? FlexShrink
        {
            get { return this._flexShrink; }
            set { this.SetProperty(ref this._flexShrink, value); }
        }

        /// <summary>
        /// Specifies whether flex items are forced into a single line or can be wrapped onto
        /// multiple lines. If wrapping is allowed, this property also enables you to control the
        /// direction in which lines are stacked. See CSS flex-wrap property https://drafts.csswg.org/css-flexbox-1/#flex-wrap-property
        /// </summary>
        [JsonProperty("flexWrap", NullValueHandling = NullValueHandling.Ignore)]
        public FlexWrap? FlexWrap
        {
            get { return this._flexWrap; }
            set { this.SetProperty(ref this._flexWrap, value); }
        }

        /// <summary>
        /// Elements which have the style float are floated horizontally. These elements can move as
        /// far to the left or right of the containing element. All elements after the floating
        /// element will flow around it, but elements before the floating element are not impacted.
        /// If several floating elements are placed after each other, they will float next to each
        /// other as long as there is room.
        /// </summary>
        [JsonProperty("float", NullValueHandling = NullValueHandling.Ignore)]
        public string Float
        {
            get { return this._float; }
            set { this.SetProperty(ref this._float, value); }
        }

        /// <summary>
        /// Flows content from a named flow (specified by a corresponding flow-into) through selected
        /// elements to form a dynamic chain of layout regions.
        /// </summary>
        [JsonProperty("flowFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowFrom
        {
            get { return this._flowFrom; }
            set { this.SetProperty(ref this._flowFrom, value); }
        }

        /// <summary>
        /// The font property is shorthand that allows you to do one of two things: you can either
        /// set up six of the most mature font properties in one line, or you can set one of a choice
        /// of keywords to adopt a system font setting.
        /// </summary>
        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public string Font
        {
            get { return this._font; }
            set { this.SetProperty(ref this._font, value); }
        }

        /// <summary>
        /// The font-family property allows one or more font family names and/or generic family names
        /// to be specified for usage on the selected element(s)' text. The browser then goes through
        /// the list; for each character in the selection it applies the first font family that has
        /// an available glyph for that character.
        /// </summary>
        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string FontFamily
        {
            get { return this._fontFamily; }
            set { this.SetProperty(ref this._fontFamily, value); }
        }

        /// <summary>
        /// The font-kerning property allows contextual adjustment of inter-glyph spacing, i.e. the
        /// spaces between the characters in text. This property controls <bold>metric kerning</bold>
        /// - that utilizes adjustment data contained in the font. Optical Kerning is not supported
        /// as yet.
        /// </summary>
        [JsonProperty("fontKerning", NullValueHandling = NullValueHandling.Ignore)]
        public string FontKerning
        {
            get { return this._fontKerning; }
            set { this.SetProperty(ref this._fontKerning, value); }
        }

        /// <summary>
        /// Specifies the size of the font. Used to compute em and ex units. See CSS 3 font-size
        /// property https://www.w3.org/TR/css-fonts-3/#propdef-font-size
        /// </summary>
        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? FontSize
        {
            get { return this._fontSize; }
            set { this.SetProperty(ref this._fontSize, value); }
        }

        /// <summary>
        /// The font-size-adjust property adjusts the font-size of the fallback fonts defined with
        /// font-family, so that the x-height is the same no matter what font is used. This preserves
        /// the readability of the text when fallback happens. See CSS 3 font-size-adjust property https://www.w3.org/TR/css-fonts-3/#propdef-font-size-adjust
        /// </summary>
        [JsonProperty("fontSizeAdjust", NullValueHandling = NullValueHandling.Ignore)]
        public FontSizeAdjust? FontSizeAdjust
        {
            get { return this._fontSizeAdjust; }
            set { this.SetProperty(ref this._fontSizeAdjust, value); }
        }

        /// <summary>
        /// Allows you to expand or condense the widths for a normal, condensed, or expanded font
        /// face. See CSS 3 font-stretch property https://drafts.csswg.org/css-fonts-3/#propdef-font-stretch
        /// </summary>
        [JsonProperty("fontStretch", NullValueHandling = NullValueHandling.Ignore)]
        public FontStretch? FontStretch
        {
            get { return this._fontStretch; }
            set { this.SetProperty(ref this._fontStretch, value); }
        }

        /// <summary>
        /// The font-style property allows normal, italic, or oblique faces to be selected. Italic
        /// forms are generally cursive in nature while oblique faces are typically sloped versions
        /// of the regular face. Oblique faces can be simulated by artificially sloping the glyphs of
        /// the regular face. See CSS 3 font-style property https://www.w3.org/TR/css-fonts-3/#propdef-font-style
        /// </summary>
        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public FontStyle? FontStyle
        {
            get { return this._fontStyle; }
            set { this.SetProperty(ref this._fontStyle, value); }
        }

        /// <summary>
        /// This value specifies whether the user agent is allowed to synthesize bold or oblique font
        /// faces when a font family lacks bold or italic faces.
        /// </summary>
        [JsonProperty("fontSynthesis", NullValueHandling = NullValueHandling.Ignore)]
        public string FontSynthesis
        {
            get { return this._fontSynthesis; }
            set { this.SetProperty(ref this._fontSynthesis, value); }
        }

        /// <summary>
        /// The font-variant property enables you to select the small-caps font within a font family.
        /// </summary>
        [JsonProperty("fontVariant", NullValueHandling = NullValueHandling.Ignore)]
        public string FontVariant
        {
            get { return this._fontVariant; }
            set { this.SetProperty(ref this._fontVariant, value); }
        }

        /// <summary>
        /// Fonts can provide alternate glyphs in addition to default glyph for a character. This
        /// property provides control over the selection of these alternate glyphs.
        /// </summary>
        [JsonProperty("fontVariantAlternates", NullValueHandling = NullValueHandling.Ignore)]
        public string FontVariantAlternates
        {
            get { return this._fontVariantAlternates; }
            set { this.SetProperty(ref this._fontVariantAlternates, value); }
        }

        /// <summary>
        /// Specifies the weight or boldness of the font. See CSS 3 'font-weight' property https://www.w3.org/TR/css-fonts-3/#propdef-font-weight
        /// </summary>
        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public FontWeight? FontWeight
        {
            get { return this._fontWeight; }
            set { this.SetProperty(ref this._fontWeight, value); }
        }

        /// <summary>
        /// Lays out one or more grid items bound by 4 grid lines. Shorthand for setting
        /// grid-column-start, grid-column-end, grid-row-start, and grid-row-end in a single declaration.
        /// </summary>
        [JsonProperty("gridArea", NullValueHandling = NullValueHandling.Ignore)]
        public string GridArea
        {
            get { return this._gridArea; }
            set { this.SetProperty(ref this._gridArea, value); }
        }

        /// <summary>
        /// Controls a grid item's placement in a grid area, particularly grid position and a grid
        /// span. Shorthand for setting grid-column-start and grid-column-end in a single declaration.
        /// </summary>
        [JsonProperty("gridColumn", NullValueHandling = NullValueHandling.Ignore)]
        public string GridColumn
        {
            get { return this._gridColumn; }
            set { this.SetProperty(ref this._gridColumn, value); }
        }

        /// <summary>
        /// Controls a grid item's placement in a grid area as well as grid position and a grid span.
        /// The grid-column-end property (with grid-row-start, grid-row-end, and grid-column-start)
        /// determines a grid item's placement by specifying the grid lines of a grid item's grid area.
        /// </summary>
        [JsonProperty("gridColumnEnd", NullValueHandling = NullValueHandling.Ignore)]
        public string GridColumnEnd
        {
            get { return this._gridColumnEnd; }
            set { this.SetProperty(ref this._gridColumnEnd, value); }
        }

        /// <summary>
        /// Determines a grid item's placement by specifying the starting grid lines of a grid item's
        /// grid area . A grid item's placement in a grid area consists of a grid position and a grid
        /// span. See also ( grid-row-start, grid-row-end, and grid-column-end)
        /// </summary>
        [JsonProperty("gridColumnStart", NullValueHandling = NullValueHandling.Ignore)]
        public string GridColumnStart
        {
            get { return this._gridColumnStart; }
            set { this.SetProperty(ref this._gridColumnStart, value); }
        }

        /// <summary>
        /// Gets or sets a value that indicates which row an element within a Grid should appear in.
        /// Shorthand for setting grid-row-start and grid-row-end in a single declaration.
        /// </summary>
        [JsonProperty("gridRow", NullValueHandling = NullValueHandling.Ignore)]
        public string GridRow
        {
            get { return this._gridRow; }
            set { this.SetProperty(ref this._gridRow, value); }
        }

        /// <summary>
        /// Determines a grid item’s placement by specifying the block-end. A grid item's placement
        /// in a grid area consists of a grid position and a grid span. The grid-row-end property
        /// (with grid-row-start, grid-column-start, and grid-column-end) determines a grid item's
        /// placement by specifying the grid lines of a grid item's grid area.
        /// </summary>
        [JsonProperty("gridRowEnd", NullValueHandling = NullValueHandling.Ignore)]
        public string GridRowEnd
        {
            get { return this._gridRowEnd; }
            set { this.SetProperty(ref this._gridRowEnd, value); }
        }

        /// <summary>
        /// Specifies a row position based upon an integer location, string value, or desired row
        /// size. css/properties/grid-row is used as short-hand for grid-row-position and grid-row-position
        /// </summary>
        [JsonProperty("gridRowPosition", NullValueHandling = NullValueHandling.Ignore)]
        public string GridRowPosition
        {
            get { return this._gridRowPosition; }
            set { this.SetProperty(ref this._gridRowPosition, value); }
        }

        /// <summary>
        /// Specifies named grid areas which are not associated with any particular grid item, but
        /// can be referenced from the grid-placement properties. The syntax of the
        /// grid-template-areas property also provides a visualization of the structure of the grid,
        /// making the overall layout of the grid container easier to understand.
        /// </summary>
        [JsonProperty("gridTemplateAreas", NullValueHandling = NullValueHandling.Ignore)]
        public string GridTemplateAreas
        {
            get { return this._gridTemplateAreas; }
            set { this.SetProperty(ref this._gridTemplateAreas, value); }
        }

        /// <summary>
        /// Specifies (with grid-template-rows) the line names and track sizing functions of the
        /// grid. Each sizing function can be specified as a length, a percentage of the grid
        /// container’s size, a measurement of the contents occupying the column or row, or a
        /// fraction of the free space in the grid.
        /// </summary>
        [JsonProperty("gridTemplateColumns", NullValueHandling = NullValueHandling.Ignore)]
        public string GridTemplateColumns
        {
            get { return this._gridTemplateColumns; }
            set { this.SetProperty(ref this._gridTemplateColumns, value); }
        }

        /// <summary>
        /// Specifies (with grid-template-columns) the line names and track sizing functions of the
        /// grid. Each sizing function can be specified as a length, a percentage of the grid
        /// container’s size, a measurement of the contents occupying the column or row, or a
        /// fraction of the free space in the grid.
        /// </summary>
        [JsonProperty("gridTemplateRows", NullValueHandling = NullValueHandling.Ignore)]
        public string GridTemplateRows
        {
            get { return this._gridTemplateRows; }
            set { this.SetProperty(ref this._gridTemplateRows, value); }
        }

        /// <summary>
        /// Sets the height of an element. The content area of the element height does not include
        /// the padding, border, and margin of the element.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Height
        {
            get { return this._height; }
            set { this.SetProperty(ref this._height, value); }
        }

        /// <summary>
        /// Specifies the minimum number of characters in a hyphenated word
        /// </summary>
        [JsonProperty("hyphenateLimitChars", NullValueHandling = NullValueHandling.Ignore)]
        public string HyphenateLimitChars
        {
            get { return this._hyphenateLimitChars; }
            set { this.SetProperty(ref this._hyphenateLimitChars, value); }
        }

        /// <summary>
        /// Indicates the maximum number of successive hyphenated lines in an element. The ‘no-limit’
        /// value means that there is no limit.
        /// </summary>
        [JsonProperty("hyphenateLimitLines", NullValueHandling = NullValueHandling.Ignore)]
        public string HyphenateLimitLines
        {
            get { return this._hyphenateLimitLines; }
            set { this.SetProperty(ref this._hyphenateLimitLines, value); }
        }

        /// <summary>
        /// Specifies the maximum amount of trailing whitespace (before justification) that may be
        /// left in a line before hyphenation is triggered to pull part of a word from the next line
        /// back up into the current one.
        /// </summary>
        [JsonProperty("hyphenateLimitZone", NullValueHandling = NullValueHandling.Ignore)]
        public string HyphenateLimitZone
        {
            get { return this._hyphenateLimitZone; }
            set { this.SetProperty(ref this._hyphenateLimitZone, value); }
        }

        /// <summary>
        /// Specifies whether or not words in a sentence can be split by the use of a manual or
        /// automatic hyphenation mechanism.
        /// </summary>
        [JsonProperty("hyphens", NullValueHandling = NullValueHandling.Ignore)]
        public string Hyphens
        {
            get { return this._hyphens; }
            set { this.SetProperty(ref this._hyphens, value); }
        }

        /// <summary>
        /// Defines how the browser distributes space between and around flex items along the
        /// main-axis of their container. See CSS justify-content property https://www.w3.org/TR/css-flexbox-1/#justify-content-property
        /// </summary>
        [JsonProperty("justifyContent", NullValueHandling = NullValueHandling.Ignore)]
        public JustifyContent? JustifyContent
        {
            get { return this._justifyContent; }
            set { this.SetProperty(ref this._justifyContent, value); }
        }

        /// <summary>
        /// Sets the left position of an element relative to the nearest anscestor that is set to
        /// position absolute, relative, or fixed.
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Left
        {
            get { return this._left; }
            set { this.SetProperty(ref this._left, value); }
        }

        /// <summary>
        /// The letter-spacing CSS property specifies the spacing behavior between text characters.
        /// </summary>
        [JsonProperty("letterSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public string LetterSpacing
        {
            get { return this._letterSpacing; }
            set { this.SetProperty(ref this._letterSpacing, value); }
        }

        /// <summary>
        /// Specifies the height of an inline block level element. See CSS 2.1 line-height property https://www.w3.org/TR/CSS21/visudet.html#propdef-line-height
        /// </summary>
        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? LineHeight
        {
            get { return this._lineHeight; }
            set { this.SetProperty(ref this._lineHeight, value); }
        }

        /// <summary>
        /// Shorthand property that sets the list-style-type, list-style-position and
        /// list-style-image properties in one declaration.
        /// </summary>
        [JsonProperty("listStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string ListStyle
        {
            get { return this._listStyle; }
            set { this.SetProperty(ref this._listStyle, value); }
        }

        /// <summary>
        /// This property sets the image that will be used as the list item marker. When the image is
        /// available, it will replace the marker set with the 'list-style-type' marker. That also
        /// means that if the image is not available, it will show the style specified by list-style-property
        /// </summary>
        [JsonProperty("listStyleImage", NullValueHandling = NullValueHandling.Ignore)]
        public string ListStyleImage
        {
            get { return this._listStyleImage; }
            set { this.SetProperty(ref this._listStyleImage, value); }
        }

        /// <summary>
        /// Specifies if the list-item markers should appear inside or outside the content flow.
        /// </summary>
        [JsonProperty("listStylePosition", NullValueHandling = NullValueHandling.Ignore)]
        public string ListStylePosition
        {
            get { return this._listStylePosition; }
            set { this.SetProperty(ref this._listStylePosition, value); }
        }

        /// <summary>
        /// Specifies the type of list-item marker in a list.
        /// </summary>
        [JsonProperty("listStyleType", NullValueHandling = NullValueHandling.Ignore)]
        public string ListStyleType
        {
            get { return this._listStyleType; }
            set { this.SetProperty(ref this._listStyleType, value); }
        }

        /// <summary>
        /// The margin property is shorthand to allow you to set all four margins of an element at
        /// once. Its equivalent longhand properties are margin-top, margin-right, margin-bottom and
        /// margin-left. Negative values are also allowed.
        /// </summary>
        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Margin
        {
            get { return this._margin; }
            set { this.SetProperty(ref this._margin, value); }
        }

        /// <summary>
        /// margin-bottom sets the bottom margin of an element.
        /// </summary>
        [JsonProperty("marginBottom", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MarginBottom
        {
            get { return this._marginBottom; }
            set { this.SetProperty(ref this._marginBottom, value); }
        }

        /// <summary>
        /// margin-left sets the left margin of an element.
        /// </summary>
        [JsonProperty("marginLeft", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MarginLeft
        {
            get { return this._marginLeft; }
            set { this.SetProperty(ref this._marginLeft, value); }
        }

        /// <summary>
        /// margin-right sets the right margin of an element.
        /// </summary>
        [JsonProperty("marginRight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MarginRight
        {
            get { return this._marginRight; }
            set { this.SetProperty(ref this._marginRight, value); }
        }

        /// <summary>
        /// margin-top sets the top margin of an element.
        /// </summary>
        [JsonProperty("marginTop", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MarginTop
        {
            get { return this._marginTop; }
            set { this.SetProperty(ref this._marginTop, value); }
        }

        /// <summary>
        /// The marquee-direction determines the initial direction in which the marquee content moves.
        /// </summary>
        [JsonProperty("marqueeDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string MarqueeDirection
        {
            get { return this._marqueeDirection; }
            set { this.SetProperty(ref this._marqueeDirection, value); }
        }

        /// <summary>
        /// The 'marquee-style' property determines a marquee's scrolling behavior.
        /// </summary>
        [JsonProperty("marqueeStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string MarqueeStyle
        {
            get { return this._marqueeStyle; }
            set { this.SetProperty(ref this._marqueeStyle, value); }
        }

        /// <summary>
        /// This property is shorthand for setting mask-image, mask-mode, mask-repeat, mask-position,
        /// mask-clip, mask-origin, mask-composite and mask-size. Omitted values are set to their
        /// original properties' initial values.
        /// </summary>
        [JsonProperty("mask", NullValueHandling = NullValueHandling.Ignore)]
        public string Mask
        {
            get { return this._mask; }
            set { this.SetProperty(ref this._mask, value); }
        }

        /// <summary>
        /// This property is shorthand for setting mask-border-source, mask-border-slice,
        /// mask-border-width, mask-border-outset, and mask-border-repeat. Omitted values are set to
        /// their original properties' initial values.
        /// </summary>
        [JsonProperty("maskBorder", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBorder
        {
            get { return this._maskBorder; }
            set { this.SetProperty(ref this._maskBorder, value); }
        }

        /// <summary>
        /// This property specifies how the images for the sides and the middle part of the mask
        /// image are scaled and tiled. The first keyword applies to the horizontal sides, the second
        /// one applies to the vertical ones. If the second keyword is absent, it is assumed to be
        /// the same as the first, similar to the CSS border-image-repeat property.
        /// </summary>
        [JsonProperty("maskBorderRepeat", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBorderRepeat
        {
            get { return this._maskBorderRepeat; }
            set { this.SetProperty(ref this._maskBorderRepeat, value); }
        }

        /// <summary>
        /// This property specifies inward offsets from the top, right, bottom, and left edges of the
        /// mask image, dividing it into nine regions: four corners, four edges, and a middle. The
        /// middle image part is discarded and treated as fully transparent black unless the fill
        /// keyword is present. The four values set the top, right, bottom and left offsets in that
        /// order, similar to the CSS border-image-slice property.
        /// </summary>
        [JsonProperty("maskBorderSlice", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBorderSlice
        {
            get { return this._maskBorderSlice; }
            set { this.SetProperty(ref this._maskBorderSlice, value); }
        }

        /// <summary>
        /// Specifies an image to be used as a mask. An image that is empty, fails to download, is
        /// non-existent, or cannot be displayed is ignored and does not mask the element.
        /// </summary>
        [JsonProperty("maskBorderSource", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBorderSource
        {
            get { return this._maskBorderSource; }
            set { this.SetProperty(ref this._maskBorderSource, value); }
        }

        /// <summary>
        /// This property sets the width of the mask box image, similar to the CSS border-image-width property.
        /// </summary>
        [JsonProperty("maskBorderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MaskBorderWidth
        {
            get { return this._maskBorderWidth; }
            set { this.SetProperty(ref this._maskBorderWidth, value); }
        }

        /// <summary>
        /// Determines the mask painting area, which defines the area that is affected by the mask.
        /// The painted content of an element may be restricted to this area.
        /// </summary>
        [JsonProperty("maskClip", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskClip
        {
            get { return this._maskClip; }
            set { this.SetProperty(ref this._maskClip, value); }
        }

        /// <summary>
        /// For elements rendered as a single box, specifies the mask positioning area. For elements
        /// rendered as multiple boxes (e.g., inline boxes on several lines, boxes on several pages)
        /// specifies which boxes box-decoration-break operates on to determine the mask positioning area(s).
        /// </summary>
        [JsonProperty("maskOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskOrigin
        {
            get { return this._maskOrigin; }
            set { this.SetProperty(ref this._maskOrigin, value); }
        }

        /// <summary>
        /// This property must not be used. It is no longer included in any standard or standard
        /// track specification, nor is it implemented in any browser. It is only used when the
        /// text-align-last property is set to size. It controls allowed adjustments of font-size to
        /// fit line content.
        /// </summary>
        [JsonProperty("maxFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MaxFontSize
        {
            get { return this._maxFontSize; }
            set { this.SetProperty(ref this._maxFontSize, value); }
        }

        /// <summary>
        /// Sets the maximum height for an element. It prevents the height of the element to exceed
        /// the specified value. If min-height is specified and is greater than max-height,
        /// max-height is overridden.
        /// </summary>
        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MaxHeight
        {
            get { return this._maxHeight; }
            set { this.SetProperty(ref this._maxHeight, value); }
        }

        /// <summary>
        /// Sets the maximum width for an element. It limits the width property to be larger than the
        /// value specified in max-width.
        /// </summary>
        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MaxWidth
        {
            get { return this._maxWidth; }
            set { this.SetProperty(ref this._maxWidth, value); }
        }

        /// <summary>
        /// Sets the minimum height for an element. It prevents the height of the element to be
        /// smaller than the specified value. The value of min-height overrides both max-height and height.
        /// </summary>
        [JsonProperty("minHeight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MinHeight
        {
            get { return this._minHeight; }
            set { this.SetProperty(ref this._minHeight, value); }
        }

        /// <summary>
        /// Sets the minimum width of an element. It limits the width property to be not smaller than
        /// the value specified in min-width.
        /// </summary>
        [JsonProperty("minWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? MinWidth
        {
            get { return this._minWidth; }
            set { this.SetProperty(ref this._minWidth, value); }
        }

        /// <summary>
        /// (Moz specific) font smoothing directive.
        /// </summary>
        [JsonProperty("MozOsxFontSmoothing", NullValueHandling = NullValueHandling.Ignore)]
        public FontSmoothing? MozOsxFontSmoothing
        {
            get { return this._mozOsxFontSmoothing; }
            set { this.SetProperty(ref this._mozOsxFontSmoothing, value); }
        }

        /// <summary>
        /// (Ms specific) constrast adjust rule.
        /// </summary>
        [JsonProperty("MsHighContrastAdjust", NullValueHandling = NullValueHandling.Ignore)]
        public string MsHighContrastAdjust
        {
            get { return this._msHighContrastAdjust; }
            set { this.SetProperty(ref this._msHighContrastAdjust, value); }
        }

        /// <summary>
        /// Specifies the transparency of an element. See CSS 3 opacity property https://drafts.csswg.org/css-color-3/#opacity
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Opacity
        {
            get { return this._opacity; }
            set { this.SetProperty(ref this._opacity, value); }
        }

        /// <summary>
        /// Specifies the order used to lay out flex items in their flex container. Elements are laid
        /// out in the ascending order of the order value. See CSS order property https://drafts.csswg.org/css-flexbox-1/#order-property
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public FillOpacity? Order
        {
            get { return this._order; }
            set { this.SetProperty(ref this._order, value); }
        }

        /// <summary>
        /// In paged media, this property defines the minimum number of lines in a block container
        /// that must be left at the bottom of the page. See CSS 3 orphans, widows properties https://drafts.csswg.org/css-break-3/#widows-orphans
        /// </summary>
        [JsonProperty("orphans", NullValueHandling = NullValueHandling.Ignore)]
        public FillOpacity? Orphans
        {
            get { return this._orphans; }
            set { this.SetProperty(ref this._orphans, value); }
        }

        /// <summary>
        /// The CSS outline property is a shorthand property for setting one or more of the
        /// individual outline properties outline-style, outline-width and outline-color in a single
        /// rule. In most cases the use of this shortcut is preferable and more convenient. Outlines
        /// differ from borders in the following ways: • Outlines do not take up space, they are
        /// drawn above the content. • Outlines may be non-rectangular. They are rectangular in
        /// Gecko/Firefox. Internet Explorer attempts to place the smallest contiguous outline around
        /// all elements or shapes that are indicated to have an outline. Opera draws a
        /// non-rectangular shape around a construct.
        /// </summary>
        [JsonProperty("outline", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Outline
        {
            get { return this._outline; }
            set { this.SetProperty(ref this._outline, value); }
        }

        /// <summary>
        /// The outline-color property sets the color of the outline of an element. An outline is a
        /// line that is drawn around elements, outside the border edge, to make the element stand out.
        /// </summary>
        [JsonProperty("outlineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string OutlineColor
        {
            get { return this._outlineColor; }
            set { this.SetProperty(ref this._outlineColor, value); }
        }

        /// <summary>
        /// The outline-offset property offsets the outline and draw it beyond the border edge.
        /// </summary>
        [JsonProperty("outlineOffset", NullValueHandling = NullValueHandling.Ignore)]
        public string OutlineOffset
        {
            get { return this._outlineOffset; }
            set { this.SetProperty(ref this._outlineOffset, value); }
        }

        /// <summary>
        /// The overflow property controls how extra content exceeding the bounding box of an element
        /// is rendered. It can be used in conjunction with an element that has a fixed width and
        /// height, to eliminate text-induced page distortion.
        /// </summary>
        [JsonProperty("overflow", NullValueHandling = NullValueHandling.Ignore)]
        public Overflow? Overflow
        {
            get { return this._overflow; }
            set { this.SetProperty(ref this._overflow, value); }
        }

        /// <summary>
        /// Specifies the preferred scrolling methods for elements that overflow.
        /// </summary>
        [JsonProperty("overflowStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string OverflowStyle
        {
            get { return this._overflowStyle; }
            set { this.SetProperty(ref this._overflowStyle, value); }
        }

        /// <summary>
        /// Specifies whether or not the browser should insert line breaks within words to prevent
        /// text from overflowing its content box. In contrast to word-break, overflow-wrap will only
        /// create a break if an entire word cannot be placed on its own line without overflowing.
        /// </summary>
        [JsonProperty("overflowWrap", NullValueHandling = NullValueHandling.Ignore)]
        public OverflowWrap? OverflowWrap
        {
            get { return this._overflowWrap; }
            set { this.SetProperty(ref this._overflowWrap, value); }
        }

        /// <summary>
        /// Controls how extra content exceeding the x-axis of the bounding box of an element is rendered.
        /// </summary>
        [JsonProperty("overflowX", NullValueHandling = NullValueHandling.Ignore)]
        public Overflow? OverflowX
        {
            get { return this._overflowX; }
            set { this.SetProperty(ref this._overflowX, value); }
        }

        /// <summary>
        /// Controls how extra content exceeding the y-axis of the bounding box of an element is rendered.
        /// </summary>
        [JsonProperty("overflowY", NullValueHandling = NullValueHandling.Ignore)]
        public Overflow? OverflowY
        {
            get { return this._overflowY; }
            set { this.SetProperty(ref this._overflowY, value); }
        }

        /// <summary>
        /// The padding optional CSS property sets the required padding space on one to four sides of
        /// an element. The padding area is the space between an element and its border. Negative
        /// values are not allowed but decimal values are permitted. The element size is treated as
        /// fixed, and the content of the element shifts toward the center as padding is increased.
        /// The padding property is a shorthand to avoid setting each side separately (padding-top,
        /// padding-right, padding-bottom, padding-left).
        /// </summary>
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Padding
        {
            get { return this._padding; }
            set { this.SetProperty(ref this._padding, value); }
        }

        /// <summary>
        /// The padding-bottom CSS property of an element sets the padding space required on the
        /// bottom of an element. The padding area is the space between the content of the element
        /// and its border. Contrary to margin-bottom values, negative values of padding-bottom are invalid.
        /// </summary>
        [JsonProperty("paddingBottom", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? PaddingBottom
        {
            get { return this._paddingBottom; }
            set { this.SetProperty(ref this._paddingBottom, value); }
        }

        /// <summary>
        /// The padding-left CSS property of an element sets the padding space required on the left
        /// side of an element. The padding area is the space between the content of the element and
        /// its border. Contrary to margin-left values, negative values of padding-left are invalid.
        /// </summary>
        [JsonProperty("paddingLeft", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? PaddingLeft
        {
            get { return this._paddingLeft; }
            set { this.SetProperty(ref this._paddingLeft, value); }
        }

        /// <summary>
        /// The padding-right CSS property of an element sets the padding space required on the right
        /// side of an element. The padding area is the space between the content of the element and
        /// its border. Contrary to margin-right values, negative values of padding-right are invalid.
        /// </summary>
        [JsonProperty("paddingRight", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? PaddingRight
        {
            get { return this._paddingRight; }
            set { this.SetProperty(ref this._paddingRight, value); }
        }

        /// <summary>
        /// The padding-top CSS property of an element sets the padding space required on the top of
        /// an element. The padding area is the space between the content of the element and its
        /// border. Contrary to margin-top values, negative values of padding-top are invalid.
        /// </summary>
        [JsonProperty("paddingTop", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? PaddingTop
        {
            get { return this._paddingTop; }
            set { this.SetProperty(ref this._paddingTop, value); }
        }

        /// <summary>
        /// The page-break-after property is supported in all major browsers. With CSS3, page-break-*
        /// properties are only aliases of the break-* properties. The CSS3 Fragmentation spec
        /// defines breaks for all CSS box fragmentation.
        /// </summary>
        [JsonProperty("pageBreakAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string PageBreakAfter
        {
            get { return this._pageBreakAfter; }
            set { this.SetProperty(ref this._pageBreakAfter, value); }
        }

        /// <summary>
        /// The page-break-before property sets the page-breaking behavior before an element. With
        /// CSS3, page-break-* properties are only aliases of the break-* properties. The CSS3
        /// Fragmentation spec defines breaks for all CSS box fragmentation.
        /// </summary>
        [JsonProperty("pageBreakBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string PageBreakBefore
        {
            get { return this._pageBreakBefore; }
            set { this.SetProperty(ref this._pageBreakBefore, value); }
        }

        /// <summary>
        /// Sets the page-breaking behavior inside an element. With CSS3, page-break-* properties are
        /// only aliases of the break-* properties. The CSS3 Fragmentation spec defines breaks for
        /// all CSS box fragmentation.
        /// </summary>
        [JsonProperty("pageBreakInside", NullValueHandling = NullValueHandling.Ignore)]
        public string PageBreakInside
        {
            get { return this._pageBreakInside; }
            set { this.SetProperty(ref this._pageBreakInside, value); }
        }

        /// <summary>
        /// The pause property determines how long a speech media agent should pause before and after
        /// presenting an element. It is a shorthand for the pause-before and pause-after properties.
        /// </summary>
        [JsonProperty("pause", NullValueHandling = NullValueHandling.Ignore)]
        public string Pause
        {
            get { return this._pause; }
            set { this.SetProperty(ref this._pause, value); }
        }

        /// <summary>
        /// The pause-after property determines how long a speech media agent should pause after
        /// presenting an element. It may be replaced by the shorthand property pause, which sets
        /// pause time before and after.
        /// </summary>
        [JsonProperty("pauseAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string PauseAfter
        {
            get { return this._pauseAfter; }
            set { this.SetProperty(ref this._pauseAfter, value); }
        }

        /// <summary>
        /// The pause-before property determines how long a speech media agent should pause before
        /// presenting an element. It may be replaced by the shorthand property pause, which sets
        /// pause time before and after.
        /// </summary>
        [JsonProperty("pauseBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string PauseBefore
        {
            get { return this._pauseBefore; }
            set { this.SetProperty(ref this._pauseBefore, value); }
        }

        /// <summary>
        /// The perspective property defines how far an element is placed from the view on the
        /// z-axis, from the screen to the viewer. Perspective defines how an object is viewed. In
        /// graphic arts, perspective is the representation on a flat surface of what the viewer's
        /// eye would see in a 3D space. (See Wikipedia for more information about graphical
        /// perspective and for related illustrations.) The illusion of perspective on a flat
        /// surface, such as a computer screen, is created by projecting points on the flat surface
        /// as they would appear if the flat surface were a window through which the viewer was
        /// looking at the object. In discussion of virtual environments, this flat surface is called
        /// a projection plane.
        /// </summary>
        [JsonProperty("perspective", NullValueHandling = NullValueHandling.Ignore)]
        public string Perspective
        {
            get { return this._perspective; }
            set { this.SetProperty(ref this._perspective, value); }
        }

        /// <summary>
        /// The perspective-origin property establishes the origin for the perspective property. It
        /// effectively sets the X and Y position at which the viewer appears to be looking at the
        /// children of the element. When used with perspective, perspective-origin changes the
        /// appearance of an object, as if a viewer were looking at it from a different origin. An
        /// object appears differently if a viewer is looking directly at it versus looking at it
        /// from below, above, or from the side. Thus, the perspective-origin is like a vanishing
        /// point. The default value of perspective-origin is 50% 50%. This displays an object as if
        /// the viewer's eye were positioned directly at the center of the screen, both top-to-bottom
        /// and left-to-right. A value of 0% 0% changes the object as if the viewer was looking
        /// toward the top left angle. A value of 100% 100% changes the appearance as if viewed
        /// toward the bottom right angle.
        /// </summary>
        [JsonProperty("perspectiveOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public string PerspectiveOrigin
        {
            get { return this._perspectiveOrigin; }
            set { this.SetProperty(ref this._perspectiveOrigin, value); }
        }

        /// <summary>
        /// The pointer-events property allows you to control whether an element can be the target
        /// for the pointing device (e.g, mouse, pen) events.
        /// </summary>
        [JsonProperty("pointerEvents", NullValueHandling = NullValueHandling.Ignore)]
        public string PointerEvents
        {
            get { return this._pointerEvents; }
            set { this.SetProperty(ref this._pointerEvents, value); }
        }

        /// <summary>
        /// The position property controls the type of positioning used by an element within its
        /// parent elements. The effect of the position property depends on a lot of factors, for
        /// example the position property of parent elements.
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public Position? Position
        {
            get { return this._position; }
            set { this.SetProperty(ref this._position, value); }
        }

        /// <summary>
        /// Sets the type of quotation marks for embedded quotations.
        /// </summary>
        [JsonProperty("quotes", NullValueHandling = NullValueHandling.Ignore)]
        public string Quotes
        {
            get { return this._quotes; }
            set { this.SetProperty(ref this._quotes, value); }
        }

        /// <summary>
        /// Controls whether the last region in a chain displays additional 'overset' content
        /// according its default overflow property, or if it displays a fragment of content as if it
        /// were flowing into a subsequent region.
        /// </summary>
        [JsonProperty("regionFragment", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionFragment
        {
            get { return this._regionFragment; }
            set { this.SetProperty(ref this._regionFragment, value); }
        }

        /// <summary>
        /// The resize CSS sets whether an element is resizable, and if so, in which direction(s).
        /// </summary>
        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public Resize? Resize
        {
            get { return this._resize; }
            set { this.SetProperty(ref this._resize, value); }
        }

        /// <summary>
        /// The rest-after property determines how long a speech media agent should pause after
        /// presenting an element's main content, before presenting that element's exit cue sound. It
        /// may be replaced by the shorthand property rest, which sets rest time before and after.
        /// </summary>
        [JsonProperty("restAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string RestAfter
        {
            get { return this._restAfter; }
            set { this.SetProperty(ref this._restAfter, value); }
        }

        /// <summary>
        /// The rest-before property determines how long a speech media agent should pause after
        /// presenting an intro cue sound for an element, before presenting that element's main
        /// content. It may be replaced by the shorthand property rest, which sets rest time before
        /// and after.
        /// </summary>
        [JsonProperty("restBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string RestBefore
        {
            get { return this._restBefore; }
            set { this.SetProperty(ref this._restBefore, value); }
        }

        /// <summary>
        /// Specifies the position an element in relation to the right side of the containing element.
        /// </summary>
        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Right
        {
            get { return this._right; }
            set { this.SetProperty(ref this._right, value); }
        }

        /// <summary>
        /// Defines the alpha channel threshold used to extract a shape from an image. Can be thought
        /// of as a "minimum opacity" threshold; that is, a value of 0.5 means that the shape will
        /// enclose all the pixels that are more than 50% opaque.
        /// </summary>
        [JsonProperty("shapeImageThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public string ShapeImageThreshold
        {
            get { return this._shapeImageThreshold; }
            set { this.SetProperty(ref this._shapeImageThreshold, value); }
        }

        /// <summary> A future level of CSS Shapes will define a shape-inside property, which will
        /// define a shape to wrap content within the element. See Editor's Draft
        /// <http://dev.w3.org/csswg/css-shapes/> and CSSWG wiki page on next-level plans
        /// <http://wiki.csswg.org/spec/css-shapes> </summary>
        [JsonProperty("shapeInside", NullValueHandling = NullValueHandling.Ignore)]
        public string ShapeInside
        {
            get { return this._shapeInside; }
            set { this.SetProperty(ref this._shapeInside, value); }
        }

        /// <summary>
        /// Adds a margin to a shape-outside. In effect, defines a new shape that is the smallest
        /// contour around all the points that are the shape-margin distance outward perpendicular to
        /// each point on the underlying shape. For points where a perpendicular direction is not
        /// defined (e.g., a triangle corner), takes all points on a circle centered at the point and
        /// with a radius of the shape-margin distance. This property accepts only non-negative values.
        /// </summary>
        [JsonProperty("shapeMargin", NullValueHandling = NullValueHandling.Ignore)]
        public string ShapeMargin
        {
            get { return this._shapeMargin; }
            set { this.SetProperty(ref this._shapeMargin, value); }
        }

        /// <summary>
        /// Declares a shape around which text should be wrapped, with possible modifications from
        /// the shape-margin property. The shape defined by shape-outside and shape-margin changes
        /// the geometry of a float element's float area.
        /// </summary>
        [JsonProperty("shapeOutside", NullValueHandling = NullValueHandling.Ignore)]
        public string ShapeOutside
        {
            get { return this._shapeOutside; }
            set { this.SetProperty(ref this._shapeOutside, value); }
        }

        /// <summary>
        /// The speak property determines whether or not a speech synthesizer will read aloud the
        /// contents of an element.
        /// </summary>
        [JsonProperty("speak", NullValueHandling = NullValueHandling.Ignore)]
        public string Speak
        {
            get { return this._speak; }
            set { this.SetProperty(ref this._speak, value); }
        }

        /// <summary>
        /// The speak-as property determines how the speech synthesizer interprets the content: words
        /// as whole words or as a sequence of letters, numbers as a numerical value or a sequence of
        /// digits, punctuation as pauses in speech or named punctuation characters.
        /// </summary>
        [JsonProperty("speakAs", NullValueHandling = NullValueHandling.Ignore)]
        public string SpeakAs
        {
            get { return this._speakAs; }
            set { this.SetProperty(ref this._speakAs, value); }
        }

        /// <summary>
        /// The stroke property in CSS is for adding a border to SVG shapes. See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#Stroke
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public string Stroke
        {
            get { return this._stroke; }
            set { this.SetProperty(ref this._stroke, value); }
        }

        /// <summary>
        /// SVG: Specifies the opacity of the outline on the current object. See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeOpacityProperty
        /// </summary>
        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public FillOpacity? StrokeOpacity
        {
            get { return this._strokeOpacity; }
            set { this.SetProperty(ref this._strokeOpacity, value); }
        }

        /// <summary>
        /// SVG: Specifies the width of the outline on the current object. See SVG 1.1 https://www.w3.org/TR/SVG/painting.html#StrokeWidthProperty
        /// </summary>
        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? StrokeWidth
        {
            get { return this._strokeWidth; }
            set { this.SetProperty(ref this._strokeWidth, value); }
        }

        /// <summary>
        /// The 'table-layout' property controls the algorithm used to lay out the table cells, rows,
        /// and columns.
        /// </summary>
        [JsonProperty("tableLayout", NullValueHandling = NullValueHandling.Ignore)]
        public string TableLayout
        {
            get { return this._tableLayout; }
            set { this.SetProperty(ref this._tableLayout, value); }
        }

        /// <summary>
        /// The tab-size CSS property is used to customise the width of a tab (U+0009) character.
        /// </summary>
        [JsonProperty("tabSize", NullValueHandling = NullValueHandling.Ignore)]
        public string TabSize
        {
            get { return this._tabSize; }
            set { this.SetProperty(ref this._tabSize, value); }
        }

        /// <summary>
        /// The text-align CSS property describes how inline content like text is aligned in its
        /// parent block element. text-align does not control the alignment of block elements itself,
        /// only their inline content.
        /// </summary>
        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlign
        {
            get { return this._textAlign; }
            set { this.SetProperty(ref this._textAlign, value); }
        }

        /// <summary>
        /// The text-align-last CSS property describes how the last line of a block element or a line
        /// before line break is aligned in its parent block element.
        /// </summary>
        [JsonProperty("textAlignLast", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlignLast
        {
            get { return this._textAlignLast; }
            set { this.SetProperty(ref this._textAlignLast, value); }
        }

        /// <summary>
        /// The text-decoration CSS property is used to set the text formatting to underline,
        /// overline, line-through or blink. underline and overline decorations are positioned under
        /// the text, line-through over it.
        /// </summary>
        [JsonProperty("textDecoration", NullValueHandling = NullValueHandling.Ignore)]
        public string TextDecoration
        {
            get { return this._textDecoration; }
            set { this.SetProperty(ref this._textDecoration, value); }
        }

        /// <summary>
        /// Sets the color of any text decoration, such as underlines, overlines, and strike throughs.
        /// </summary>
        [JsonProperty("textDecorationColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TextDecorationColor
        {
            get { return this._textDecorationColor; }
            set { this.SetProperty(ref this._textDecorationColor, value); }
        }

        /// <summary>
        /// Sets what kind of line decorations are added to an element, such as underlines,
        /// overlines, etc.
        /// </summary>
        [JsonProperty("textDecorationLine", NullValueHandling = NullValueHandling.Ignore)]
        public string TextDecorationLine
        {
            get { return this._textDecorationLine; }
            set { this.SetProperty(ref this._textDecorationLine, value); }
        }

        /// <summary>
        /// Specifies what parts of an element’s content are skipped over when applying any text decoration.
        /// </summary>
        [JsonProperty("textDecorationSkip", NullValueHandling = NullValueHandling.Ignore)]
        public string TextDecorationSkip
        {
            get { return this._textDecorationSkip; }
            set { this.SetProperty(ref this._textDecorationSkip, value); }
        }

        /// <summary>
        /// This property specifies the style of the text decoration line drawn on the specified
        /// element. The intended meaning for the values are the same as those of the border-style-properties.
        /// </summary>
        [JsonProperty("textDecorationStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TextDecorationStyle
        {
            get { return this._textDecorationStyle; }
            set { this.SetProperty(ref this._textDecorationStyle, value); }
        }

        /// <summary>
        /// The text-emphasis property will apply special emphasis marks to the elements text.
        /// Slightly similar to the text-decoration property only that this property can have affect
        /// on the line-height. It also is noted that this is shorthand for text-emphasis-style and
        /// for text-emphasis-color.
        /// </summary>
        [JsonProperty("textEmphasis", NullValueHandling = NullValueHandling.Ignore)]
        public string TextEmphasis
        {
            get { return this._textEmphasis; }
            set { this.SetProperty(ref this._textEmphasis, value); }
        }

        /// <summary>
        /// The text-emphasis-color property specifies the foreground color of the emphasis marks.
        /// </summary>
        [JsonProperty("textEmphasisColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TextEmphasisColor
        {
            get { return this._textEmphasisColor; }
            set { this.SetProperty(ref this._textEmphasisColor, value); }
        }

        /// <summary>
        /// The text-emphasis-style property applies special emphasis marks to an element's text.
        /// </summary>
        [JsonProperty("textEmphasisStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TextEmphasisStyle
        {
            get { return this._textEmphasisStyle; }
            set { this.SetProperty(ref this._textEmphasisStyle, value); }
        }

        /// <summary>
        /// This property helps determine an inline box's block-progression dimension, derived from
        /// the text-height and font-size properties for non-replaced elements, the height or the
        /// width for replaced elements, and the stacked block-progression dimension for inline-block
        /// elements. The block-progression dimension determines the position of the padding, border
        /// and margin for the element.
        /// </summary>
        [JsonProperty("textHeight", NullValueHandling = NullValueHandling.Ignore)]
        public string TextHeight
        {
            get { return this._textHeight; }
            set { this.SetProperty(ref this._textHeight, value); }
        }

        /// <summary>
        /// Specifies the amount of space horizontally that should be left on the first line of the
        /// text of an element. This horizontal spacing is at the beginning of the first line and is
        /// in respect to the left edge of the containing block box.
        /// </summary>
        [JsonProperty("textIndent", NullValueHandling = NullValueHandling.Ignore)]
        public string TextIndent
        {
            get { return this._textIndent; }
            set { this.SetProperty(ref this._textIndent, value); }
        }

        /// <summary>
        /// The text-overflow shorthand CSS property determines how overflowed content that is not
        /// displayed is signaled to the users. It can be clipped, display an ellipsis ('…', U+2026
        /// HORIZONTAL ELLIPSIS) or a Web author-defined string. It covers the two long-hand
        /// properties text-overflow-mode and text-overflow-ellipsis
        /// </summary>
        [JsonProperty("textOverflow", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOverflow
        {
            get { return this._textOverflow; }
            set { this.SetProperty(ref this._textOverflow, value); }
        }

        /// <summary>
        /// The text-overline property is the shorthand for the text-overline-style,
        /// text-overline-width, text-overline-color, and text-overline-mode properties.
        /// </summary>
        [JsonProperty("textOverline", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOverline
        {
            get { return this._textOverline; }
            set { this.SetProperty(ref this._textOverline, value); }
        }

        /// <summary>
        /// Specifies the line color for the overline text decoration.
        /// </summary>
        [JsonProperty("textOverlineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOverlineColor
        {
            get { return this._textOverlineColor; }
            set { this.SetProperty(ref this._textOverlineColor, value); }
        }

        /// <summary>
        /// Sets the mode for the overline text decoration, determining whether the text decoration
        /// affects the space characters or not.
        /// </summary>
        [JsonProperty("textOverlineMode", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOverlineMode
        {
            get { return this._textOverlineMode; }
            set { this.SetProperty(ref this._textOverlineMode, value); }
        }

        /// <summary>
        /// Specifies the line style for overline text decoration.
        /// </summary>
        [JsonProperty("textOverlineStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TextOverlineStyle
        {
            get { return this._textOverlineStyle; }
            set { this.SetProperty(ref this._textOverlineStyle, value); }
        }

        /// <summary>
        /// Specifies the line width for the overline text decoration.
        /// </summary>
        [JsonProperty("textOverlineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? TextOverlineWidth
        {
            get { return this._textOverlineWidth; }
            set { this.SetProperty(ref this._textOverlineWidth, value); }
        }

        /// <summary>
        /// The text-rendering CSS property provides information to the browser about how to optimize
        /// when rendering text. Options are: legibility, speed or geometric precision.
        /// </summary>
        [JsonProperty("textRendering", NullValueHandling = NullValueHandling.Ignore)]
        public string TextRendering
        {
            get { return this._textRendering; }
            set { this.SetProperty(ref this._textRendering, value); }
        }

        /// <summary> The CSS text-shadow property applies one or more drop shadows to the text and
        /// <text-decorations> of an element. Each shadow is specified as an offset from the text,
        /// along with optional color and blur radius values. </summary>
        [JsonProperty("textShadow", NullValueHandling = NullValueHandling.Ignore)]
        public string TextShadow
        {
            get { return this._textShadow; }
            set { this.SetProperty(ref this._textShadow, value); }
        }

        /// <summary>
        /// This property transforms text for styling purposes. (It has no effect on the underlying content.)
        /// </summary>
        [JsonProperty("textTransform", NullValueHandling = NullValueHandling.Ignore)]
        public string TextTransform
        {
            get { return this._textTransform; }
            set { this.SetProperty(ref this._textTransform, value); }
        }

        /// <summary>
        /// Unsupported. This property will add a underline position value to the element that has an
        /// underline defined.
        /// </summary>
        [JsonProperty("textUnderlinePosition", NullValueHandling = NullValueHandling.Ignore)]
        public string TextUnderlinePosition
        {
            get { return this._textUnderlinePosition; }
            set { this.SetProperty(ref this._textUnderlinePosition, value); }
        }

        /// <summary>
        /// After review this should be replaced by text-decoration should it not? This property will
        /// set the underline style for text with a line value for underline, overline, and line-through.
        /// </summary>
        [JsonProperty("textUnderlineStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TextUnderlineStyle
        {
            get { return this._textUnderlineStyle; }
            set { this.SetProperty(ref this._textUnderlineStyle, value); }
        }

        /// <summary>
        /// This property specifies how far an absolutely positioned box's top margin edge is offset
        /// below the top edge of the box's containing block. For relatively positioned boxes, the
        /// offset is with respect to the top edges of the box itself (i.e., the box is given a
        /// position in the normal flow, then offset from that position according to these properties).
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Top
        {
            get { return this._top; }
            set { this.SetProperty(ref this._top, value); }
        }

        /// <summary>
        /// Determines whether touch input may trigger default behavior supplied by the user agent,
        /// such as panning or zooming.
        /// </summary>
        [JsonProperty("touchAction", NullValueHandling = NullValueHandling.Ignore)]
        public string TouchAction
        {
            get { return this._touchAction; }
            set { this.SetProperty(ref this._touchAction, value); }
        }

        /// <summary>
        /// CSS transforms allow elements styled with CSS to be transformed in two-dimensional or
        /// three-dimensional space. Using this property, elements can be translated, rotated,
        /// scaled, and skewed. The value list may consist of 2D and/or 3D transform values.
        /// </summary>
        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public string Transform
        {
            get { return this._transform; }
            set { this.SetProperty(ref this._transform, value); }
        }

        /// <summary>
        /// This property defines the origin of the transformation axes relative to the element to
        /// which the transformation is applied.
        /// </summary>
        [JsonProperty("transformOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public string TransformOrigin
        {
            get { return this._transformOrigin; }
            set { this.SetProperty(ref this._transformOrigin, value); }
        }

        /// <summary>
        /// This property allows you to define the relative position of the origin of the
        /// transformation grid along the z-axis.
        /// </summary>
        [JsonProperty("transformOriginZ", NullValueHandling = NullValueHandling.Ignore)]
        public string TransformOriginZ
        {
            get { return this._transformOriginZ; }
            set { this.SetProperty(ref this._transformOriginZ, value); }
        }

        /// <summary>
        /// This property specifies how nested elements are rendered in 3D space relative to their parent.
        /// </summary>
        [JsonProperty("transformStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string TransformStyle
        {
            get { return this._transformStyle; }
            set { this.SetProperty(ref this._transformStyle, value); }
        }

        /// <summary>
        /// The transition CSS property is a shorthand property for transition-property,
        /// transition-duration, transition-timing-function, and transition-delay. It allows to
        /// define the transition between two states of an element.
        /// </summary>
        [JsonProperty("transition", NullValueHandling = NullValueHandling.Ignore)]
        public string Transition
        {
            get { return this._transition; }
            set { this.SetProperty(ref this._transition, value); }
        }

        /// <summary>
        /// Defines when the transition will start. A value of ‘0s’ means the transition will execute
        /// as soon as the property is changed. Otherwise, the value specifies an offset from the
        /// moment the property is changed, and the transition will delay execution by that offset.
        /// </summary>
        [JsonProperty("transitionDelay", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitionDelay
        {
            get { return this._transitionDelay; }
            set { this.SetProperty(ref this._transitionDelay, value); }
        }

        /// <summary>
        /// The 'transition-duration' property specifies the length of time a transition animation
        /// takes to complete.
        /// </summary>
        [JsonProperty("transitionDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitionDuration
        {
            get { return this._transitionDuration; }
            set { this.SetProperty(ref this._transitionDuration, value); }
        }

        /// <summary>
        /// The 'transition-property' property specifies the name of the CSS property to which the
        /// transition is applied.
        /// </summary>
        [JsonProperty("transitionProperty", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitionProperty
        {
            get { return this._transitionProperty; }
            set { this.SetProperty(ref this._transitionProperty, value); }
        }

        /// <summary>
        /// Sets the pace of action within a transition
        /// </summary>
        [JsonProperty("transitionTimingFunction", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitionTimingFunction
        {
            get { return this._transitionTimingFunction; }
            set { this.SetProperty(ref this._transitionTimingFunction, value); }
        }

        /// <summary>
        /// The unicode-bidi CSS property specifies the level of embedding with respect to the
        /// bidirectional algorithm.
        /// </summary>
        [JsonProperty("unicodeBidi", NullValueHandling = NullValueHandling.Ignore)]
        public string UnicodeBidi
        {
            get { return this._unicodeBidi; }
            set { this.SetProperty(ref this._unicodeBidi, value); }
        }

        /// <summary>
        /// This is for all the high level UX stuff.
        /// </summary>
        [JsonProperty("userFocus", NullValueHandling = NullValueHandling.Ignore)]
        public string UserFocus
        {
            get { return this._userFocus; }
            set { this.SetProperty(ref this._userFocus, value); }
        }

        /// <summary>
        /// For inputing user content
        /// </summary>
        [JsonProperty("userInput", NullValueHandling = NullValueHandling.Ignore)]
        public string UserInput
        {
            get { return this._userInput; }
            set { this.SetProperty(ref this._userInput, value); }
        }

        /// <summary>
        /// Defines the text selection behavior.
        /// </summary>
        [JsonProperty("userSelect", NullValueHandling = NullValueHandling.Ignore)]
        public UserSelect? UserSelect
        {
            get { return this._userSelect; }
            set { this.SetProperty(ref this._userSelect, value); }
        }

        /// <summary>
        /// The vertical-align property controls how inline elements or text are vertically aligned
        /// compared to the baseline. If this property is used on table-cells it controls the
        /// vertical alignment of content of the table cell.
        /// </summary>
        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign
        {
            get { return this._verticalAlign; }
            set { this.SetProperty(ref this._verticalAlign, value); }
        }

        /// <summary>
        /// The visibility property specifies whether the boxes generated by an element are rendered.
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility
        {
            get { return this._visibility; }
            set { this.SetProperty(ref this._visibility, value); }
        }

        /// <summary>
        /// The voice-balance property sets the apparent position (in stereo sound) of the
        /// synthesized voice for spoken media.
        /// </summary>
        [JsonProperty("voiceBalance", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceBalance
        {
            get { return this._voiceBalance; }
            set { this.SetProperty(ref this._voiceBalance, value); }
        }

        /// <summary>
        /// The voice-duration property allows the author to explicitly set the amount of time it
        /// should take a speech synthesizer to read an element's content, for example to allow the
        /// speech to be synchronized with other media. With a value of auto (the
        /// default) the length of time it takes to read the content is determined by the content
        /// itself and the voice-rate property.
        /// </summary>
        [JsonProperty("voiceDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceDuration
        {
            get { return this._voiceDuration; }
            set { this.SetProperty(ref this._voiceDuration, value); }
        }

        /// <summary>
        /// The voice-family property sets the speaker's voice used by a speech media agent to read
        /// an element. The speaker may be specified as a named character (to match a voice option in
        /// the speech reading software) or as a generic description of the age and gender of the
        /// voice. Similar to the font-family property for visual media, a comma-separated list of
        /// fallback options may be given in case the speech reader does not recognize the character
        /// name or cannot synthesize the requested combination of generic properties.
        /// </summary>
        [JsonProperty("voiceFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceFamily
        {
            get { return this._voiceFamily; }
            set { this.SetProperty(ref this._voiceFamily, value); }
        }

        /// <summary>
        /// The voice-pitch property sets pitch or tone (high or low) for the synthesized speech when
        /// reading an element; the pitch may be specified absolutely or relative to the normal pitch
        /// for the voice-family used to read the text.
        /// </summary>
        [JsonProperty("voicePitch", NullValueHandling = NullValueHandling.Ignore)]
        public string VoicePitch
        {
            get { return this._voicePitch; }
            set { this.SetProperty(ref this._voicePitch, value); }
        }

        /// <summary>
        /// The voice-range property determines how much variation in pitch or tone will be created
        /// by the speech synthesize when reading an element. Emphasized text, grammatical structures
        /// and punctuation may all be rendered as changes in pitch, this property determines how
        /// strong or obvious those changes are; large ranges are associated with enthusiastic or
        /// emotional speech, while small ranges are associated with flat or mechanical speech.
        /// </summary>
        [JsonProperty("voiceRange", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceRange
        {
            get { return this._voiceRange; }
            set { this.SetProperty(ref this._voiceRange, value); }
        }

        /// <summary>
        /// The voice-rate property sets the speed at which the voice synthesized by a speech media
        /// agent will read content.
        /// </summary>
        [JsonProperty("voiceRate", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceRate
        {
            get { return this._voiceRate; }
            set { this.SetProperty(ref this._voiceRate, value); }
        }

        /// <summary>
        /// The voice-stress property sets the level of vocal emphasis to be used for synthesized
        /// speech reading the element.
        /// </summary>
        [JsonProperty("voiceStress", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceStress
        {
            get { return this._voiceStress; }
            set { this.SetProperty(ref this._voiceStress, value); }
        }

        /// <summary>
        /// The voice-volume property sets the volume for spoken content in speech media. It replaces
        /// the deprecated volume property.
        /// </summary>
        [JsonProperty("voiceVolume", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceVolume
        {
            get { return this._voiceVolume; }
            set { this.SetProperty(ref this._voiceVolume, value); }
        }

        /// <summary>
        /// (Webkit specific) font smoothing directive.
        /// </summary>
        [JsonProperty("WebkitFontSmoothing", NullValueHandling = NullValueHandling.Ignore)]
        public FontSmoothing? WebkitFontSmoothing
        {
            get { return this._webkitFontSmoothing; }
            set { this.SetProperty(ref this._webkitFontSmoothing, value); }
        }

        /// <summary>
        /// (Webkit specific) momentum scrolling on iOS devices
        /// </summary>
        [JsonProperty("WebkitOverflowScrolling", NullValueHandling = NullValueHandling.Ignore)]
        public WebkitOverflowScrolling? WebkitOverflowScrolling
        {
            get { return this._webkitOverflowScrolling; }
            set { this.SetProperty(ref this._webkitOverflowScrolling, value); }
        }

        /// <summary>
        /// The white-space property controls whether and how white space inside the element is
        /// collapsed, and whether lines may wrap at unforced "soft wrap" opportunities.
        /// </summary>
        [JsonProperty("whiteSpace", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteSpace
        {
            get { return this._whiteSpace; }
            set { this.SetProperty(ref this._whiteSpace, value); }
        }

        /// <summary>
        /// In paged media, this property defines the mimimum number of lines that must be left at
        /// the top of the second page. See CSS 3 orphans, widows properties https://drafts.csswg.org/css-break-3/#widows-orphans
        /// </summary>
        [JsonProperty("widows", NullValueHandling = NullValueHandling.Ignore)]
        public FillOpacity? Widows
        {
            get { return this._widows; }
            set { this.SetProperty(ref this._widows, value); }
        }

        /// <summary>
        /// Specifies the width of the content area of an element. The content area of the element
        /// width does not include the padding, border, and margin of the element.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Width
        {
            get { return this._width; }
            set { this.SetProperty(ref this._width, value); }
        }

        /// <summary>
        /// The word-break property is often used when there is long generated content that is strung
        /// together without and spaces or hyphens to beak apart. A common case of this is when there
        /// is a long URL that does not have any hyphens. This case could potentially cause the
        /// breaking of the layout as it could extend past the parent element.
        /// </summary>
        [JsonProperty("wordBreak", NullValueHandling = NullValueHandling.Ignore)]
        public string WordBreak
        {
            get { return this._wordBreak; }
            set { this.SetProperty(ref this._wordBreak, value); }
        }

        /// <summary>
        /// The word-spacing CSS property specifies the spacing behavior between "words".
        /// </summary>
        [JsonProperty("wordSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public string WordSpacing
        {
            get { return this._wordSpacing; }
            set { this.SetProperty(ref this._wordSpacing, value); }
        }

        /// <summary>
        /// An alias of css/properties/overflow-wrap, word-wrap defines whether to break words when
        /// the content exceeds the boundaries of its container.
        /// </summary>
        [JsonProperty("wordWrap", NullValueHandling = NullValueHandling.Ignore)]
        public string WordWrap
        {
            get { return this._wordWrap; }
            set { this.SetProperty(ref this._wordWrap, value); }
        }

        /// <summary>
        /// Specifies how exclusions affect inline content within block-level elements. Elements lay
        /// out their inline content in their content area but wrap around exclusion areas.
        /// </summary>
        [JsonProperty("wrapFlow", NullValueHandling = NullValueHandling.Ignore)]
        public string WrapFlow
        {
            get { return this._wrapFlow; }
            set { this.SetProperty(ref this._wrapFlow, value); }
        }

        /// <summary>
        /// Set the value that is used to offset the inner wrap shape from other shapes. Inline
        /// content that intersects a shape with this property will be pushed by this shape's margin.
        /// </summary>
        [JsonProperty("wrapMargin", NullValueHandling = NullValueHandling.Ignore)]
        public string WrapMargin
        {
            get { return this._wrapMargin; }
            set { this.SetProperty(ref this._wrapMargin, value); }
        }

        /// <summary>
        /// writing-mode specifies if lines of text are laid out horizontally or vertically, and the
        /// direction which lines of text and blocks progress.
        /// </summary>
        [JsonProperty("writingMode", NullValueHandling = NullValueHandling.Ignore)]
        public string WritingMode
        {
            get { return this._writingMode; }
            set { this.SetProperty(ref this._writingMode, value); }
        }

        /// <summary>
        /// The z-index property specifies the z-order of an element and its descendants. When
        /// elements overlap, z-order determines which one covers the other. See CSS 2 z-index
        /// property https://www.w3.org/TR/CSS2/visuren.html#z-index
        /// </summary>
        [JsonProperty("zIndex", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnCount? ZIndex
        {
            get { return this._zIndex; }
            set { this.SetProperty(ref this._zIndex, value); }
        }

        /// <summary>
        /// Sets the initial zoom factor of a document defined by @viewport. See CSS zoom descriptor https://drafts.csswg.org/css-device-adapt/#zoom-desc
        /// </summary>
        [JsonProperty("zoom", NullValueHandling = NullValueHandling.Ignore)]
        public CssValue? Zoom
        {
            get { return this._zoom; }
            set { this.SetProperty(ref this._zoom, value); }
        }
    }
}