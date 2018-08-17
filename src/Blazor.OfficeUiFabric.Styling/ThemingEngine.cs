using Blazor.Extensions.MergeStyles;
using Blazor.OfficeUiFabric.Styling.Extensions;
using Blazor.OfficeUiFabric.Styling.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{
    public class ThemingEngine
    {
        private Theme theme;
        const string ThemeSettingName = "theme";
        private readonly ILoadThemeStyle loadThemeStyle;

        public ThemingEngine(ILoadThemeStyle loadThemeStyle)
        {
            this.loadThemeStyle = loadThemeStyle;
        }

        public event EventHandler<Theme> ThemeChanged;

        public static Lazy<Theme> DefaultTheme = new Lazy<Theme>(() =>
        {
            var palette = Palette.DefaultPalette;
            var semacticColors = palette.MakeSemanticColors(false, false);
            var theme = new Theme()
            {
                IsInverted = false,
                Palette = palette,
                Fonts = FontStyles.DefaultFontStyle,
                SemacticColors = semacticColors,
                DisableGlobalCalssNames = false,
                Typography = Typography.DefaultTypography
            };
            return theme;
        });


        /// <summary>
        ///  Checks for the `disableGlobalClassNames` property on the `theme` to determine if it should return `classNames`
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="classNames">The global class names that apply when the flag is false</param>
        /// <param name="theme">The theme to check the flag on</param>
        /// <returns></returns>
        public T GetGlobalClassNames<T>(T classNames, Theme theme)
            where T : StyleSet, new()
        {
            if (theme.DisableGlobalCalssNames)
            {
                return new T();
            }

            return classNames;
        }

        /// <summary>
        /// Creates a custom theme definition which can be used with the Customizer.
        /// </summary>
        /// <param name="theme">Partial theme object.</param>
        /// <param name="depComments">Whether to include deprecated tags as comments for deprecated slots.</param>
        /// <returns></returns>
        public Theme CreateTheme(Theme theme, bool depComments = false)
        {
            var newPalette = new Palette();
            newPalette = newPalette.MergeValues(Palette.DefaultPalette, theme.Palette);

            if (theme.Palette == null || theme.Palette.Accent == null)
            {
                newPalette.Accent = newPalette.ThemePrimary;
            }
            var newSemacticColors = new SemanticColors().MergeValues(newPalette.MakeSemanticColors(theme?.IsInverted == true, depComments), theme.SemacticColors);

            var typography = new Typography().MergeValues(Typography.DefaultTypography, theme.Typography);

            var types = typography.Types;

            foreach (var typeName in types)
            {

                var type = typeName.Value;

                string fontFamily;
                if (!string.IsNullOrWhiteSpace(type.FontFamily) && typography.Families.TryGetValue(type.FontFamily, out fontFamily))
                {
                    type.FontFamily = fontFamily;
                }

                string fontSize;
                if (type.FontSize != null && typography.Sizes.TryGetValue((string)type.FontSize, out fontSize))
                {
                    type.FontSize = typography.Sizes[fontSize];
                }

                string fontWeight;
                if (type.FontWeight != null && typography.Families.TryGetValue((string)type.FontWeight, out fontWeight))
                {
                    type.FontWeight = fontWeight;
                }

            }

            return new Theme()
            {
                Palette = newPalette,
                Fonts = new FontStyles().MergeValues(FontStyles.DefaultFontStyle, theme.Fonts),
                SemacticColors = newSemacticColors,
                IsInverted = theme?.IsInverted == true,
                DisableGlobalCalssNames = theme?.DisableGlobalCalssNames == true,
                Typography = typography
            };
        }


        public Theme LoadTheme(Theme theme, bool depComments = false)
        {
            this.theme = CreateTheme(theme, depComments);
            this.loadThemeStyle.LoadTheme(this.theme);
            this.ThemeChanged?.Invoke(this, this.theme);
            return this.theme;
        }



    }
}
