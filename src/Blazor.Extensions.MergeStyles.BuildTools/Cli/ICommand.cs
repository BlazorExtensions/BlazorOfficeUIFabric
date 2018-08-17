using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.BuildTools
{
    public interface ICommandAsync
    {
        /// <summary>
        /// Execute the command async
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        Task<int> OnExecuteAsync(CommandLineApplication app);

      
    }
    public interface ICommand
    {
        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        int OnExecute(CommandLineApplication app);
    }
}
