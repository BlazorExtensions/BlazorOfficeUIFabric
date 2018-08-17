using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace Blazor.Extensions.MergeStyles.BuildTools
{
    [HelpOption("-?|-h|--help")]
    [Command(Description = "Asserts that Node.js is installed.")]
    public class CheckToolCommand : ICommand
    {
        [Option("-v|--version", "Specifies a minimum acceptable version of Node.js.", CommandOptionType.SingleValue)]
        public string MinVersion { get; set; }

        [Argument(1, Description = "Tool to check")]
        public string Tool { get; set; }

        public int OnExecute(CommandLineApplication app)
        {
            var foundNodeVersion = GetInstalledNodeVersion();
            if (foundNodeVersion == null)
            {
                return 1;
            }

            if (!string.IsNullOrWhiteSpace(this.MinVersion))
            {
                var minVersion = new Version(this.MinVersion);
                if (foundNodeVersion < minVersion)
                {
                    Console.WriteLine($"ERROR: The installed version of Node.js is too old. Required version: {minVersion}; Found version: {foundNodeVersion}.");
                    return 1;
                }
            }

            Console.WriteLine($"Found Node.js version {foundNodeVersion}");
            return 0;
        }
        private static Regex NodeVersionRegex = new Regex(@"^v(\d+\.\d+\.\d+)");


        private Version GetInstalledNodeVersion()
        {
            var versionString = InvokeNodeVersionCommand();
            if (versionString == null)
            {
                return null;
            }

            var versionStringMatch = NodeVersionRegex.Match(versionString);
            if (!versionStringMatch.Success)
            {
                Console.WriteLine($"ERROR: Got unparseable Node.js version string: {versionStringMatch}");
                return null;
            }

            return new Version(versionStringMatch.Groups[1].Value);
        }

        private string InvokeNodeVersionCommand()
        {
            try
            {
                var process = Process.Start(new ProcessStartInfo
                {
                    FileName = Tool,
                    Arguments = "-v",
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"ERROR: The command '{this.Tool} -v' exited with code {process.ExitCode}.");
                    return null;
                }
                else
                {
                    return process.StandardOutput.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Node.js was not found. Ensure that Node.js is installed and that 'node' is present on the system PATH.");
                Console.WriteLine("The underlying error was: " + ex.Message);
                return null;
            }
        }
    }
}
