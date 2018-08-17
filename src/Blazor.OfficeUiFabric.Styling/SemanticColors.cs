using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{
    /// <summary>
    /// The collection of semantic slots for colors used in themes.
    ///
    /// ## Naming Convention
    ///
    /// The name of a semantic slot can quickly tell you how it’s meant to be used. It generally
    /// follows this format:
    ///
    /// [category name][element name][checked state][hovered/pressed/disabled state]
    /// [category name] – The “family” that this slot belongs to.
    /// [element name] – The name of the thing being targeted, such as the background or border.
    /// [checked state] – Whether the thing is checked. We assume things are unchecked by
    /// default, so no need to specify the unchecked state.
    /// (We used “checked” to refer to anything that is on, selected, toggled, highlighted,
    /// emphasized, etc.)
    /// [hovered/pressed/disabled state] – One of these states, if applicable. Each of these
    /// states are mutually exclusive.
    /// Pressed styles overwrite hovered styles, and disabled elements cannot be hovered or
    /// pressed.
    ///
    /// ## Base Slots
    ///
    /// A basic set of slots that provide many default body styles, such as text, subtext,
    /// disabled colors, and so on.
    /// If a category doesn't provide the slot you're looking for, use one from this category.
    /// For example, the placeholder text on a text input field has no corresponding slot in its
    /// category,
    /// so you'd use the bodySubtextColor from this category.
    ///
    /// ## Invariants
    ///
    /// When color has meaning, we do not want to change the color much theme to theme. For
    /// example, we
    /// will always want errors to be some shade of red, but we will need to tweak the exact
    /// shade so it's
    /// legible depending on whether it's an inverted theme or not.
    /// Invariant colors should almost never be changed by the theme, the defaults should
    /// suffice.
    ///
    /// ## Input Controls
    ///
    /// This category contains input components commonly used to denote state, including radio
    /// buttons,
    /// check boxes, toggle switches, sliders, progress bars, and more.
    ///
    /// ## Buttons
    ///
    /// Buttons! And all the flavors thereof.
    ///
    /// ## Menus
    ///
    /// Any kind of popup menus uses this category.
    ///
    /// ## Lists
    ///
    /// Lists differ from menus in that they are designed to show infinite amounts of items,
    /// often scroll,
    /// and have a large and complex interaction surface.
    /// This category covers all kinds of lists, whether they're typical one-item-per-row lists
    /// (like DetailsList) or ones with a tiled layout.
    /// </summary>
    public partial class SemanticColors
    {
        /// <summary>
        /// Background for blocking issues, which is more severe than a warning, but not as bad as an
        /// error.
        /// </summary>
        public string BlockingBackground { get; set; }

        /// <summary>
        /// The default color for backgrounds.
        /// </summary>
        public string BodyBackground { get; set; }

        /// <summary>
        /// Divider lines; e.g. lines that separate sections in a menu, an <HR> element.
        /// </summary>
        public string BodyDivider { get; set; }

        /// <summary>
        /// The color for chrome adjacent to an area with bodyBackground.
        /// This can be used to provide visual separation of zones when using stronger colors, when
        /// using a divider line is not desired.
        /// In most themes, this should match the color of bodyBackground.
        /// See also: bodyFrameDivider
        /// </summary>
        public string BodyFrameBackground { get; set; }

        /// <summary>
        /// Used as the border between a zone with bodyFrameBackground and a zone with
        /// bodyBackground.
        /// If bodyBackground and bodyFrameBackground are different, this should be the same color as
        /// bodyFrameBackground
        /// in order to visually disappear.
        /// See also: bodyFrameBackground
        /// </summary>
        public string BodyFrameDivider { get; set; }

        /// <summary>
        /// De-emphasized text; e.g. metadata, captions, placeholder text.
        /// </summary>
        public string BodySubtext { get; set; }

        /// <summary>
        /// The default color for text.
        /// </summary>
        public string BodyText { get; set; }

        /// <summary>
        /// Checked text color, e.g. selected menu item text.
        /// </summary>
        public string BodyTextChecked { get; set; }

        /// <summary>
        /// Background of a standard button
        /// </summary>
        public string ButtonBackground { get; set; }

        /// <summary>
        /// Background of a checked standard button; e.g. bold/italicize/underline text button in
        /// toolbar
        /// </summary>
        public string ButtonBackgroundChecked { get; set; }

        /// <summary>
        /// Background of a checked and hovered standard button; e.g. bold/italicize/underline text
        /// button in toolbar
        /// </summary>
        public string ButtonBackgroundCheckedHovered { get; set; }

        /// <summary>
        /// Background of a hovered standard button
        /// </summary>
        public string ButtonBackgroundHovered { get; set; }

        /// <summary>
        /// Border of a standard button
        /// </summary>
        public string ButtonBorder { get; set; }

        /// <summary>
        /// Color of text in a standard button
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// Color of text in a checked standard button
        /// </summary>
        public string ButtonTextChecked { get; set; }

        /// <summary>
        /// Color of text in a checked and hovered standard button
        /// </summary>
        public string ButtonTextCheckedHovered { get; set; }

        /// <summary>
        /// Color of text in a hovered standard button
        /// </summary>
        public string ButtonTextHovered { get; set; }

        /// <summary>
        /// The default color for backgrounds of disabled controls; e.g. disabled text field.
        /// </summary>
        public string DisabledBackground { get; set; }

        /// <summary>
        /// The default color for disabled text on the default background (bodyBackground).
        /// </summary>
        public string DisabledBodyText { get; set; }

        /// <summary>
        /// Disabled de-emphasized text, for use on disabledBackground.
        /// </summary>
        public string DisabledSubtext { get; set; }

        /// <summary>
        /// The default color for disabled text on top of disabledBackground; e.g. text in a disabled
        /// text field, disabled button text.
        /// </summary>
        public string DisabledText { get; set; }

        /// <summary>
        /// The background for errors, if necessary, or highlighting the section of the page where
        /// the error is present.
        /// </summary>
        public string ErrorBackground { get; set; }

        /// <summary>
        /// The default color of error text, used on bodyBackground.
        /// </summary>
        public string ErrorText { get; set; }

        /// <summary>
        /// The color of the outline around focused controls that don't already have a border; e.g.
        /// menu items
        /// </summary>
        public string FocusBorder { get; set; }

        /// <summary>
        /// The background color of an input, e.g. textbox background.
        /// </summary>
        public string InputBackground { get; set; }

        /// <summary>
        /// The background of a checked control; e.g. checked radio button's dot, checked toggle's
        /// background.
        /// </summary>
        public string InputBackgroundChecked { get; set; }

        /// <summary>
        /// The background of a checked and hovered control; e.g. checked checkbox's background color
        /// on hover.
        /// </summary>
        public string InputBackgroundCheckedHovered { get; set; }

        /// <summary>
        /// The border of a large input control in its resting, state; e.g. the box of dropdown.
        /// </summary>
        public string InputBorder { get; set; }

        /// <summary>
        /// The border color of a large hovered input control, such as textbox.
        /// </summary>
        public string InputBorderHovered { get; set; }

        /// <summary>
        /// The alternate focus border color for elements that already have a border; e.g. text field
        /// borders on focus.
        /// </summary>
        public string InputFocusBorderAlt { get; set; }

        /// <summary>
        /// The foreground of a checked control; e.g. checked checkbox's checkmark color, checked
        /// toggle's thumb color,
        /// radio button's background color around the dot.
        /// </summary>
        public string InputForegroundChecked { get; set; }

        /// <summary>
        /// The color of placeholder text.
        /// </summary>
        public string InputPlaceholderText { get; set; }

        /// <summary>
        /// The color of a link.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// The color of a hovered link. Also used when the link is active.
        /// </summary>
        public string LinkHovered { get; set; }

        /// <summary>
        /// The background color for the entire list.
        /// </summary>
        public string ListBackground { get; set; }

        /// <summary>
        /// The background color for a hovered list header.
        /// </summary>
        public string ListHeaderBackgroundHovered { get; set; }

        /// <summary>
        /// The background color for a pressed list header.
        /// </summary>
        public string ListHeaderBackgroundPressed { get; set; }

        /// <summary>
        /// The background color of a checked list item.
        /// </summary>
        public string ListItemBackgroundChecked { get; set; }

        /// <summary>
        /// The background color of a checked and hovered list item.
        /// </summary>
        public string ListItemBackgroundCheckedHovered { get; set; }

        /// <summary>
        /// The background color of a hovered list item.
        /// </summary>
        public string ListItemBackgroundHovered { get; set; }

        /// <summary>
        /// The default text color for list item titles and text in column fields.
        /// </summary>
        public string ListText { get; set; }

        /// <summary>
        /// This slot was incorrectly named. Use listText instead.
        /// </summary>
        [Obsolete("Do not use these slots, they are only maintained for backwards compatibility.")]
        public string ListTextColor { get; set; }

        /// <summary>
        /// The headers in menus that denote title of a section.
        /// </summary>
        public string MenuHeader { get; set; }

        /// <summary>
        /// The default colors of icons in menus.
        /// </summary>
        public string MenuIcon { get; set; }

        /**
         * @deprecated
         * (Checked menu items no longer get a background color.)
         * The background of checked menu item; e.g. a menu item whose submenu is open, a selected dropdown item.
         */
        [Obsolete("Checked menu items no longer get a background color.")]
        public string MenuItemBackgroundChecked { get; set; }

        /// <summary>
        /// The background of a hovered menu item.
        /// </summary>
        public string MenuItemBackgroundHovered { get; set; }

        /// <summary>
        /// The border of a small input control in its resting unchecked state; e.g. the box of an
        /// unchecked checkbox.
        /// </summary>
        public string SmallInputBorder { get; set; }

        /// <summary>
        /// Background for success
        /// </summary>
        public string SuccessBackground { get; set; }

        /// <summary>
        /// Background for warning messages.
        /// </summary>
        public string WarningBackground { get; set; }

        /// <summary>
        /// Foreground color for warning highlights
        /// </summary>
        public string WarningHighlight { get; set; }

        /// <summary>
        /// The color of text on errorBackground, warningBackground, blockingBackground, or
        /// successBackground.
        /// </summary>
        public string WarningText { get; set; }
    }

}
