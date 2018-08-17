using Blazor.OfficeUiFabric.Styling.Fonts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultStyles(this IServiceCollection services)
        {
            services.AddSingleton<IFontEngine, FontEngine>();
            
            return services;
        }


    }
}
