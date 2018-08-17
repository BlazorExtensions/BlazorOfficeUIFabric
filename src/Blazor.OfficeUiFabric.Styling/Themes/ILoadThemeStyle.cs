using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling
{
    public interface ILoadThemeStyle
    {
        void LoadStyles(ICollection<ThemingInstruction> styles, bool loadSync = false);
        void LoadStyles(string styles, bool loadAsync = false);
        void LoadTheme(Theme theme);
    }
}