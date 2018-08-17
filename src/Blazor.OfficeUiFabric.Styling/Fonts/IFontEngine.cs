using Blazor.Extensions.MergeStyles;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    public interface IFontEngine
    {
        Style CreateFont(string size, FontWeight weight, string fontFamily);
        FontStyles CreateFontStyles(string localeCode);
        string GetLocalizedFontFamily(string language);
        void RegisterDefaultFontFaces(string baseUrl);
    }
}