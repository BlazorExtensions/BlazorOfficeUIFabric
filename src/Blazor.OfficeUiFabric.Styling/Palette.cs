using System;

namespace Blazor.OfficeUiFabric.Styling
{
    /// <summary>
    /// UI Fabric color palette.
    /// </summary>
    public class Palette
    {
        /// <summary>
        /// Color code for the accent.
        /// </summary>
        public string Accent { get; set; }

        /// <summary>
        /// Color code for the strongest color, which is black in the default theme. This is a very
        /// light color in inverted themes.
        /// </summary>
        public string Black { get; set; }

        /// <summary>
        /// Color code for blackTranslucent40.
        /// </summary>
        public string BlackTranslucent40 { get; set; }

        /// <summary>
        /// Color code for blue.
        /// </summary>
        public string Blue { get; set; }

        /// <summary>
        /// Color code for blueDark.
        /// </summary>
        public string BlueDark { get; set; }

        /// <summary>
        /// Color code for blueLight.
        /// </summary>
        public string BlueLight { get; set; }

        /// <summary>
        /// Color code for blueMid.
        /// </summary>
        public string BlueMid { get; set; }

        /// <summary>
        /// Color code for green.
        /// </summary>
        public string Green { get; set; }

        /// <summary>
        /// Color code for greenDark.
        /// </summary>
        public string GreenDark { get; set; }

        /// <summary>
        /// Color code for greenLight.
        /// </summary>
        public string GreenLight { get; set; }

        /// <summary>
        /// Color code for magenta.
        /// </summary>
        public string Magenta { get; set; }

        /// <summary>
        /// Color code for magentaDark.
        /// </summary>
        public string MagentaDark { get; set; }

        /// <summary>
        /// Color code for magentaLight.
        /// </summary>
        public string MagentaLight { get; set; }

        /// <summary>
        /// Color code for neutralDark.
        /// </summary>
        public string NeutralDark { get; set; }

        /// <summary>
        /// Color code for neutralLight.
        /// </summary>
        public string NeutralLight { get; set; }

        /// <summary>
        /// Color code for neutralLighter.
        /// </summary>
        public string NeutralLighter { get; set; }

        /// <summary>
        /// Color code for neutralLighterAlt.
        /// </summary>
        public string NeutralLighterAlt { get; set; }

        /// <summary>
        /// Color code for neutralPrimary.
        /// </summary>
        public string NeutralPrimary { get; set; }

        /// <summary>
        /// Color code for neutralPrimaryAlt.
        /// </summary>
        public string NeutralPrimaryAlt { get; set; }

        /// <summary>
        /// Color code for neutralQuaternary.
        /// </summary>
        public string NeutralQuaternary { get; set; }

        /// <summary>
        /// Color code for neutralQuaternaryAlt.
        /// </summary>
        public string NeutralQuaternaryAlt { get; set; }

        /// <summary>
        /// Color code for neutralSecondary.
        /// </summary>
        public string NeutralSecondary { get; set; }

        /// <summary>
        /// Color code for neutralSecondaryAlt.
        /// </summary>
        public string NeutralSecondaryAlt { get; set; }

        /// <summary>
        /// Color code for neutralTertiary.
        /// </summary>
        public string NeutralTertiary { get; set; }

        /// <summary>
        /// Color code for neutralTertiaryAlt.
        /// </summary>
        public string NeutralTertiaryAlt { get; set; }

        /// <summary>
        /// Color code for orange.
        /// </summary>
        public string Orange { get; set; }

        /// <summary>
        /// Color code for orangeLight.
        /// </summary>
        public string OrangeLight { get; set; }

        /// <summary>
        /// Color code for orangeLighter.
        /// </summary>
        public string OrangeLighter { get; set; }

        /// <summary>
        /// Color code for purple.
        /// </summary>
        public string Purple { get; set; }

        /// <summary>
        /// Color code for purpleDark.
        /// </summary>
        public string PurpleDark { get; set; }

        /// <summary>
        /// Color code for purpleLight.
        /// </summary>
        public string PurpleLight { get; set; }

        /// <summary>
        /// Color code for red.
        /// </summary>
        public string Red { get; set; }

        /// <summary>
        /// Color code for redDark.
        /// </summary>
        public string RedDark { get; set; }

        /// <summary>
        /// Color code for teal.
        /// </summary>
        public string Teal { get; set; }

        /// <summary>
        /// Color code for tealDark.
        /// </summary>
        public string TealDark { get; set; }

        /// <summary>
        /// Color code for tealLight.
        /// </summary>
        public string TealLight { get; set; }

        /// <summary>
        /// Color code for themeDark.
        /// </summary>
        public string ThemeDark { get; set; }

        /// <summary>
        /// Color code for themeDarkAlt.
        /// </summary>
        public string ThemeDarkAlt { get; set; }

        /// <summary>
        /// Color code for themeDarker.
        /// </summary>
        public string ThemeDarker { get; set; }

        /// <summary>
        /// Color code for themeLight.
        /// </summary>
        public string ThemeLight { get; set; }

        /// <summary>
        /// Color code for themeLighter.
        /// </summary>
        public string ThemeLighter { get; set; }

        /// <summary>
        /// Color code for themeLighterAlt.
        /// </summary>
        public string ThemeLighterAlt { get; set; }

        /// <summary>
        /// Color code for themePrimary.
        /// </summary>
        public string ThemePrimary { get; set; }

        /// <summary>
        /// Color code for themeSecondary.
        /// </summary>
        public string ThemeSecondary { get; set; }

        /// <summary>
        /// Color code for themeTertiary.
        /// </summary>
        public string ThemeTertiary { get; set; }

        /// <summary>
        /// Color code for the softest color, which is white in the default theme. This is a very
        /// dark color in dark themes.
        /// This is the page background.
        /// </summary>
        public string White { get; set; }

        /// <summary>
        /// Color code for whiteTranslucent40
        /// </summary>
        public string WhiteTranslucent40 { get; set; }

        /// <summary>
        /// Color code for yellow.
        /// </summary>
        public string Yellow { get; set; }

        /// <summary>
        /// Color code for yellowLight.
        /// </summary>
        public string YellowLight { get; set; }




        public static Palette DefaultPalette => lazyDefaultPallet.Value;

        static Lazy<Palette> lazyDefaultPallet = new Lazy<Palette>(() => new Palette()
        {



            Accent = "#0078d4",

            Black = "#000000",

            BlackTranslucent40 = "rgba(0,0,0,.4)",

            Blue = "#0078d4",

            BlueDark = "#002050",

            BlueLight = "#00bcf2",

            BlueMid = "#00188f",

            Green = "#107c10",

            GreenDark = "#004b1c",

            GreenLight = "#bad80a",

            Magenta = "#b4009e",

            MagentaDark = "#5c005c",

            MagentaLight = "#e3008c",

            NeutralDark = "#212121",

            NeutralLight = "#eaeaea",

            NeutralLighter = "#f4f4f4",

            NeutralLighterAlt = "#f8f8f8",

            NeutralPrimary = "#333333",

            NeutralPrimaryAlt = "#3c3c3c",

            NeutralQuaternary = "#d0d0d0",

            NeutralQuaternaryAlt = "#dadada",

            NeutralSecondary = "#666666",

            NeutralSecondaryAlt = "#767676",

            NeutralTertiary = "#a6a6a6",

            NeutralTertiaryAlt = "#c8c8c8",

            Orange = "#d83b01",

            OrangeLight = "#ea4300",

            OrangeLighter = "#ff8c00",

            Purple = "#5c2d91",

            PurpleDark = "#32145a",

            PurpleLight = "#b4a0ff",

            Red = "#e81123",

            RedDark = "#a80000",

            Teal = "#008272",

            TealDark = "#004b50",

            TealLight = "#00b294",

            ThemeDark = "#005a9e",

            ThemeDarkAlt = "#106ebe",

            ThemeDarker = "#004578",

            ThemeLight = "#c7e0f4",

            ThemeLighter = "#deecf9",

            ThemeLighterAlt = "#eff6fc",

            ThemePrimary = "#0078d4",

            ThemeSecondary = "#2b88d8",

            ThemeTertiary = "#71afe5",

            White = "#ffffff",

            WhiteTranslucent40 = "rgba(255,255,255,.4)",

            Yellow = "#ffb900",

            YellowLight = "#fff100",
        });

        internal SemanticColors MakeSemanticColors(bool isInverted, bool depComments) => fixSlots(new SemanticColors()
        {
            BodyBackground = this.White,
            BodyFrameBackground = this.White,
            BodyFrameDivider = this.NeutralLight,
            BodyText = this.NeutralPrimary,
            BodyTextChecked = this.Black,
            BodySubtext = this.NeutralSecondary,
            BodyDivider = this.NeutralTertiaryAlt,

            DisabledBackground = this.NeutralLighter,
            DisabledText = this.NeutralTertiary,
            DisabledBodyText = this.NeutralTertiaryAlt,
            DisabledSubtext = this.NeutralQuaternary,

            FocusBorder = this.Black,

            ErrorText = !isInverted ? this.RedDark : "#ff5f5f",
            WarningText = !isInverted ? "#333333" : "#ffffff",
            ErrorBackground = !isInverted ? "rgba(232, 17, 35, .2)" : "rgba(232, 17, 35, .5)",
            BlockingBackground = !isInverted ? "rgba(234, 67, 0, .2)" : "rgba(234, 67, 0, .5)",
            WarningBackground = !isInverted ? "rgba(255, 185, 0, .2)" : "rgba(255, 251, 0, .6)",
            WarningHighlight = !isInverted ? "#ffb900" : "#fff100",
            SuccessBackground = !isInverted ? "rgba(186, 216, 10, .2)" : "rgba(186, 216, 10, .4)",

            InputBorder = this.NeutralTertiary,
            InputBorderHovered = this.NeutralDark,
            InputBackground = this.White,
            InputBackgroundChecked = this.ThemePrimary,
            InputBackgroundCheckedHovered = this.ThemeDarkAlt,
            InputForegroundChecked = this.White,
            InputFocusBorderAlt = this.ThemePrimary,
            SmallInputBorder = this.NeutralSecondary,
            InputPlaceholderText = this.NeutralSecondary,

            ButtonBackground = this.NeutralLighter,
            ButtonBackgroundChecked = this.NeutralTertiaryAlt,
            ButtonBackgroundHovered = this.NeutralLight,
            ButtonBackgroundCheckedHovered = this.NeutralLight,
            ButtonBorder = "transparent",
            ButtonText = this.NeutralPrimary,
            ButtonTextHovered = this.Black,
            ButtonTextChecked = this.NeutralDark,
            ButtonTextCheckedHovered = this.Black,

            MenuItemBackgroundHovered = this.NeutralLighter,
            MenuIcon = this.ThemePrimary,
            MenuHeader = this.ThemePrimary,

            ListBackground = this.White,
            ListText = this.NeutralPrimary,
            ListItemBackgroundHovered = this.NeutralLighter,
            ListItemBackgroundChecked = this.NeutralLight,
            ListItemBackgroundCheckedHovered = this.NeutralQuaternaryAlt,

            ListHeaderBackgroundHovered = this.NeutralLighter,
            ListHeaderBackgroundPressed = this.NeutralLight,

            Link = this.ThemePrimary,
            LinkHovered = this.ThemeDarker,

            // Deprecated slots, second pass by _fixDeprecatedSlots() later for self-referential slots
#pragma warning disable CS0618 // Type or member is obsolete
            ListTextColor = "",
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
            MenuItemBackgroundChecked = this.NeutralLight
#pragma warning restore CS0618 // Type or member is obsolete
        }, depComments);

        private SemanticColors fixSlots(SemanticColors s, bool depComments)
        {
            var dep = "";
            if (depComments)
            {
                dep = "/* @deprecated */";
            }

#pragma warning disable CS0618 // Type or member is obsolete
            s.ListTextColor = s.ListText + dep;
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
            s.MenuItemBackgroundChecked += dep;
#pragma warning restore CS0618 // Type or member is obsolete
            return s;
        }
    }
}