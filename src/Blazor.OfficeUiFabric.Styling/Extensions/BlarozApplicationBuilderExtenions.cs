using Microsoft.AspNetCore.Blazor.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Blazor.OfficeUiFabric.Styling.Fonts;

namespace Blazor.OfficeUiFabric.Styling.Extensions
{
    public static class BlarozApplicationBuilderExtenions
    {
        const string AddSerficesErrorMessage = "The Blazor OfficeUiFabric services are not configured, configure the services on ConfigureServices section";
        public static IBlazorApplicationBuilder UseDefaultStyles(this IBlazorApplicationBuilder builder)
        {
            var fontEngine = builder.Services.GetService<IFontEngine>();
            if (fontEngine is null)
                throw new InvalidOperationException(AddSerficesErrorMessage);
            var fabricConfig = builder.Services.GetService<IFabricConfig>();
            if (fabricConfig is null)
            {
                throw new InvalidOperationException(AddSerficesErrorMessage);
            }
            var baseUrl = fabricConfig?.FontBaseUrl != null ? fabricConfig.FontBaseUrl : FontEngine.DefaultBaseUrl;
            fontEngine.RegisterDefaultFontFaces(baseUrl);
            return builder;
        }
    }
}
