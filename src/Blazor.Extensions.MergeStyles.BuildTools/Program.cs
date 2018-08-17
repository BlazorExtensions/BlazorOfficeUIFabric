using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Extensions.MergeStyles.BuildTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHttpClient();
                })
                .Build();


            var app = new CommandLineApplication<StartCommand>();
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(host.Services);

            app.Execute(args);
        }
    }
}
