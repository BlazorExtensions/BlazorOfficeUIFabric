using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Extensions
{
    public static class ServiceCollectionExtensions
    {
        static StyleSheetConfig styleCofnig = new StyleSheetConfig();
        public static IServiceCollection AddMergeStyles(this IServiceCollection services, Action<StyleSheetConfig> action)
        {

            if (!services.Any(a => a.ServiceType == typeof(IJSRuntime)))
            {
                services.AddSingleton(provider => JSRuntime.Current);
            }

            services.AddSingleton(provider => new Stylesheet(styleCofnig, provider.GetService<IJSRuntime>()));
            services.AddSingleton<IStyleEngine, StyleEngine>();
            return services;
        }
    }
}
