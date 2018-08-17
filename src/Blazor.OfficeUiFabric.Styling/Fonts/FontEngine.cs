using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public class FontEngine : IFontEngine
    {

        public const string DefaultBaseUrl = "https://static2.sharepointonline.com/files/fabric/assets";

        public static FontSizes StandardFontSizes => lazyStandardFontSizes.Value;

        public static FontWeights StandardFontWeight => lazyStandardFontWeight.Value;


        private static Lazy<FontSizes> lazyStandardFontSizes = new Lazy<FontSizes>(() => new FontSizes()
        {
            Mini = "10px",
            XSmall = "11px",
            Small = "12px",
            SmallPlus = "13px",
            Medium = "14px",
            MediumPlus = "15px",
            Icon = "16px",
            Large = "17px",
            XLarge = "21px",
            XxLarge = "28px",
            SuperLarge = "42px",
            Mega = "72px",
        });
        private static Lazy<FontWeights> lazyStandardFontWeight = new Lazy<FontWeights>(() => new FontWeights
        {
            Light = 100,
            SemiLight = 300,
            Regular = 400,
            SemiBold = 600,
            Bold = 700,
        });


        public static string DefaultFontFamily => $"'Segoe UI', '{LocalizedFontNames.WestEuropean}'";


        public const string FontFamilyFallbacks = "'Segoe UI', -apple-system, BlinkMacSystemFont, 'Roboto', 'Helvetica Neue', sans-serif";
        public static Lazy<Dictionary<string, string>> LanguageToFontMap = new Lazy<Dictionary<string, string>>(() => new Dictionary<string, string>()
        {
            ["ar"] = LocalizedFontFamilies.Arabic,
            ["bg"] = LocalizedFontFamilies.Cyrillic,
            ["cs"] = LocalizedFontFamilies.EastEuropean,
            ["el"] = LocalizedFontFamilies.Greek,
            ["et"] = LocalizedFontFamilies.EastEuropean,
            ["he"] = LocalizedFontFamilies.Hebrew,
            ["hi"] = LocalizedFontFamilies.Hindi,
            ["hr"] = LocalizedFontFamilies.EastEuropean,
            ["hu"] = LocalizedFontFamilies.EastEuropean,
            ["ja"] = LocalizedFontFamilies.Japanese,
            ["kk"] = LocalizedFontFamilies.EastEuropean,
            ["ko"] = LocalizedFontFamilies.Korean,
            ["lt"] = LocalizedFontFamilies.EastEuropean,
            ["lv"] = LocalizedFontFamilies.EastEuropean,
            ["pl"] = LocalizedFontFamilies.EastEuropean,
            ["ru"] = LocalizedFontFamilies.Cyrillic,
            ["sk"] = LocalizedFontFamilies.EastEuropean,
            ["sr-latn"] = LocalizedFontFamilies.EastEuropean,
            ["th"] = LocalizedFontFamilies.Thai,
            ["tr"] = LocalizedFontFamilies.EastEuropean,
            ["uk"] = LocalizedFontFamilies.Cyrillic,
            ["vi"] = LocalizedFontFamilies.Vietnamese,
            ["zh-hans"] = LocalizedFontFamilies.ChineseSimplified,
            ["zh-hant"] = LocalizedFontFamilies.ChineseTraditional
        });


        public void RegisterDefaultFontFaces(string baseUrl)
        {

            if (!string.IsNullOrWhiteSpace(baseUrl))
            {
                var fontUrl = $"{baseUrl}/fonts";
                // Produce @font-face definitions for all supported web fonts.
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Thai, "leelawadeeui-thai", "leelawadeeui");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Arabic, "segoeui-arabic");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Cyrillic, "segoeui-cyrillic");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.EastEuropean, "segoeui-easteuropean");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Greek, "segoeui-greek");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Hebrew, "segoeui-hebrew");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.Vietnamese, "segoeui-vietnamese");
                registerFOntFaceSet(fontUrl, LocalizedFontNames.WestEuropean, "segoeui-westeuropean", "segoeui", "Segoe UI");
                registerFOntFaceSet(fontUrl, LocalizedFontFamilies.Selawik, "selawik", "selawik");

                // Leelawadee UI (Thai) does not have a 'light' weight, so we override
                // the font-face generated above to use the 'semilight' weight instead.
                registerFontFace("Leelawadee UI Web", $"{fontUrl}/leelawadeeui-thai/leelawadeeui-semilight", StandardFontWeight.Light);

                // Leelawadee UI (Thai) does not have a 'semibold' weight, so we override
                // the font-face generated above to use the 'bold' weight instead.
                registerFontFace("Leelawadee UI Web", $"{ fontUrl}/leelawadeeui-thai/leelawadeeui-bold", StandardFontWeight.SemiBold);
            }
        }
        void registerFontFace(string fontFamily, string url, FontWeight fontWeight = default, string localFontName = null)
        {
            fontFamily = $"'{fontFamily}'";
            var localFontSrc = localFontName != null ? $"local('{localFontName}')," : "";
            StyleEngine.InsertFontFace(new FontFace
            {
                FontFamily = fontFamily,
                Src = $"{localFontSrc}url('{url}.woff2') format('woff2'),url('{url}.woff') format('woff')",
                FontWeight = fontWeight,
                FontStyle = FontStyle.Normal
            });
        }

        void registerFOntFaceSet(string baseUr, string fontFamily, string cdnFolder, string cdnFontName = "segoeui", string localFontName = null)
        {
            var urlBase = $"{baseUr}/{cdnFolder}/{cdnFontName}";
            registerFontFace(fontFamily, $"{urlBase}-light", StandardFontWeight.Light, localFontName != null ? $"{localFontName} Light" : null);

            registerFontFace(fontFamily, $"{urlBase}-semilight", StandardFontWeight.SemiLight,
                localFontName != null ? $"{localFontName} SemiLight" : null);

            registerFontFace(fontFamily, $"{urlBase}-regular", StandardFontWeight.Regular,
             localFontName);

            registerFontFace(fontFamily, $"{urlBase}-semibold", StandardFontWeight.SemiBold,
                localFontName != null ? $"{localFontName} SemiBold" : null);
        }
        public static FontStyles CreateFontStyles(string localeCode)
        {
            var localizedFont = GetLocalizedFontFamily(localeCode);
            string fontFamilyWithFallback = getFontFamilyWithFallback(localizedFont);
            var semilightFontFamilyWithFallback = fontFamilyWithFallback;

            if (localizedFont == DefaultFontFamily)
            {
                semilightFontFamilyWithFallback = getFontFamilyWithFallback(LocalizedFontFamilies.WestEuropean);
            }

            var fontStyles = new FontStyles
            {
                Tiny = CreateFont(StandardFontSizes.Mini, StandardFontWeight.SemiBold, fontFamilyWithFallback),
                XSmall = CreateFont(StandardFontSizes.XSmall, StandardFontWeight.Regular, fontFamilyWithFallback),
                Small = CreateFont(StandardFontSizes.Small, StandardFontWeight.Regular, fontFamilyWithFallback),
                SmallPlus = CreateFont(StandardFontSizes.SmallPlus, StandardFontWeight.Regular, fontFamilyWithFallback),
                Medium = CreateFont(StandardFontSizes.Medium, StandardFontWeight.Regular, fontFamilyWithFallback),
                MediumPlus = CreateFont(StandardFontSizes.MediumPlus, StandardFontWeight.Regular, fontFamilyWithFallback),
                Large = CreateFont(StandardFontSizes.Large, StandardFontWeight.SemiLight, semilightFontFamilyWithFallback),
                XLarge = CreateFont(StandardFontSizes.XLarge, StandardFontWeight.Light, fontFamilyWithFallback),
                XxLarge = CreateFont(StandardFontSizes.XxLarge, StandardFontWeight.Light, fontFamilyWithFallback),
                SuperLarge = CreateFont(StandardFontSizes.SuperLarge, StandardFontWeight.Light, fontFamilyWithFallback),
                Mega = CreateFont(StandardFontSizes.Mega, StandardFontWeight.Light, fontFamilyWithFallback)
            };
            return fontStyles;
        }

        private static string getFontFamilyWithFallback(string fontFamily)
        {
            return $"{ fontFamily}, { FontFamilyFallbacks}";
        }

        public static string GetLocalizedFontFamily(string language)
        {
            string result;
            if (!string.IsNullOrWhiteSpace(language) && LanguageToFontMap.Value.TryGetValue(language, out result))
            {
                return result;
            }

            return DefaultFontFamily;
        }

        public static Style CreateFont(string size, FontWeight weight, string fontFamily)
        {
            return new Style()
            {
                FontFamily = fontFamily,
                MozOsxFontSmoothing = FontSmoothing.Grayscale,
                WebkitFontSmoothing = FontSmoothing.Antialiased,
                FontSize = size,
                FontWeight = weight,
            };
        }

        Style IFontEngine.CreateFont(string size, FontWeight weight, string fontFamily)
        {
            return CreateFont(size, weight, fontFamily);
        }

        FontStyles IFontEngine.CreateFontStyles(string localeCode)
        {
            return CreateFontStyles(localeCode);
        }

        string IFontEngine.GetLocalizedFontFamily(string language)
        {
            return GetLocalizedFontFamily(language);
        }

        void IFontEngine.RegisterDefaultFontFaces(string baseUrl)
        {
            RegisterDefaultFontFaces(baseUrl);
        }
    }
}
