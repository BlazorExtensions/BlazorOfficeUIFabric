
using Blazor.Extensions.MergeStyles;

namespace Blazor.OfficeUiFabric.Styling
{
    public class FabricConfig : IFabricConfig
    {
        public string FontBaseUrl { get; set; }

        public StyleSheetConfig MergeStyles { get; set; }
    }
}
