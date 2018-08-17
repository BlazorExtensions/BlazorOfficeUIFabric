using Blazor.Extensions.MergeStyles;

namespace Blazor.OfficeUiFabric.Styling
{
    public interface IFabricConfig
    {
        string FontBaseUrl { get; set; }
        StyleSheetConfig MergeStyles { get; set; }
    }
}