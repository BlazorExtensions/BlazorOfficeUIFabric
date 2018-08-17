using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.BuildTools
{

    [Command(Description = "MergeStyle command CLI", ThrowOnUnexpectedArgument = false)]
    [Subcommand("checktool", typeof(CheckToolCommand))]
    [Subcommand("transform", typeof(TransformCommand))]
    public class StartCommand : ICommand
    {

        public int OnExecute(CommandLineApplication app)
        {
            Console.WriteLine($"Not valid argument provide");
            app.ShowHelp();
            return 0;

        }
    }
}
