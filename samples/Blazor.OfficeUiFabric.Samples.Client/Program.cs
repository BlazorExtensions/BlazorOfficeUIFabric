using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.JSInterop;
using Mono.WebAssembly.Browser.DOM;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Samples.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            CreateHostBuilder(args).Build().Run();

        }



        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
