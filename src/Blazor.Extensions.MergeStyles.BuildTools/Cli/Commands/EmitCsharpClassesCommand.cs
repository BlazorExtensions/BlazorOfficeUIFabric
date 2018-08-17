using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Blazor.Extensions.MergeStyles.BuildTools.Models;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;

namespace Blazor.Extensions.MergeStyles.BuildTools
{

    [HelpOption(Description = "Use this command to transpile Typescript to c# a list of ts sources files" +
         "The proces has 3 steps" +
         "   1) generate schema.json files witch are used to generate the c# code" +
         "   2) the schema files are trasnform to C# code in a single file" +
         "   3) the c# file are inspected by the rules and transformed" +
         "" +
         "To used you must define a tsfiles.json with the files to be transformed and all the rules" +
         "and passed as paratemeter, the app will inspect that file and will execute the transformation  " +
         "for every especified file")]
    public class TransformCommand : ICommandAsync, IDisposable
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TransformCommand(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }
        [Argument(1)]
        public string OptionsFilePath { get; set; }
        [Option("-p", Description = "If you are runing from the MSBuild privide the current prject directory by settings -p $(ProjectDir)")]
        public string ProjectDir { get; set; }

        [Option("--density", Description = "normal|dense")]
        public string Density { get; set; } = "normal";

        [Option("--csharp-version")]
        public int CsharpVersion { get; set; } = 6;

        [Option("--array-type")]
        public string ArrayType { get; set; } = "list";

        [Option("--features")]
        public string Features { get; set; } = "complete";



        public string SourceFilePath => this.OptionsFilePath.Replace(".json", ".ts");
        public void Dispose()
        {

        }

        public async Task<int> OnExecuteAsync(CommandLineApplication app)
        {
            Console.WriteLine($"Woking directory:{AppContext.BaseDirectory}");

            if (string.IsNullOrEmpty(this.OptionsFilePath))
            {
                this.OptionsFilePath = "tsfiles.json";
            }

            EnsureFolder("schemes");
            EnsureFolder("sources");
            //reading file
            Console.WriteLine($"Reading option from {this.OptionsFilePath}");
            TransformOptions options = await GetOptions();
            Console.WriteLine($"Start to parse file to scheme from {options.Source}");
            using (var httpClient = this._httpClientFactory.CreateClient())
            {
                var mergetFile = string.Empty;
                foreach (var file in options.Files)
                {
                    if (!file.Validate())
                    {
                        Console.WriteLine($"ERROR: The output class file name {file.ClassName} is not valid please ensure ends with .cs");
                        return 1;
                    }
                    string content = await DowloadFileContent(options, httpClient, file);
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        return 1;
                    }
                    content = ExecuteRules(content, file.Rules);
                    content = ExecuteRules(content, options.Rules);
                    mergetFile += content;
                }

                mergetFile = ExecuteRules(mergetFile, options.Rules);
                await File.WriteAllTextAsync($"sources/{this.SourceFilePath}", mergetFile);

                Excecute($"sources/{this.SourceFilePath} -o schemes/{this.OptionsFilePath} --lang schema");
                foreach (var file in options.Files)
                {
                    Console.WriteLine($"Generationg scheme fro file {file.Src}");
                    Excecute($"sources/{file.Src} -o schemes/{file.SchemaPath} --lang schema");

                }
                var commandFile = $"schemes/{this.OptionsFilePath} -o Shared.cs --lang csharp --namespace {options.Namespace} " +
                      $"--csharp-version {this.CsharpVersion} --density {this.Density} --array-type {this.ArrayType} --features {this.Features}";
                Excecute(commandFile);
                foreach (var file in options.Files)
                {
                    var sourcesMaps = options.Files.Where(f => f != file).Select(f => $"-S sources/{f.SchemaPath} ");
                    var command = $"schemes/{file.SchemaPath} -o {file.ClassName} --lang csharp --namespace {options.Namespace} " +
                        $"--csharp-version {file.CsharpVersion} --density {file.Density} --array-type {file.ArrayType} --features {file.Features}";

                    Console.WriteLine("Generating class file");
                    Excecute(command);

                }

            }

            //var process = Process.
            return 0;
        }

        private string ExecuteRules(string content, ICollection<TransformationRule> rules)
        {
            Console.WriteLine($"Apliying transformation rules");
            foreach (var rule in rules)
            {
                Console.WriteLine($"Apliying rules {rule}");
                try
                {
                    if (Regex.IsMatch(content, rule.Pattern))
                    {
                        Console.WriteLine("Match found, replacing...");
                        content = Regex.Replace(content, rule.Pattern, rule.Value);
                    }
                    else
                    {
                        Console.WriteLine("None match found, replacing...");
                    }
                }
                catch (Exception)
                {
                    content = content.Replace(rule.Pattern, rule.Value);
                }
            }
            return content;
        }

        private static async Task<string> DowloadFileContent(TransformOptions options, HttpClient httpClient, TransformFile file)
        {
            var uri = new Uri(options.Source + file.Src);
            try
            {
                Console.WriteLine($"Dowloading file {uri}");
                var content = await httpClient.GetStringAsync(uri);
                await File.WriteAllTextAsync($"sources/{file.Src}", content);
                return content;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"ERROR: The file {uri} can´t be dowloaded check you internet connection, the underlyin exeption was: {ex.Message}");
                return null;
            }
        }

        private int Excecute(string arguments)
        {
            try
            {

                var quicktypeProcessInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k  {this.ProjectDir}node_modules/.bin/quicktype --quiet {arguments}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                };
                if (!string.IsNullOrEmpty(this.ProjectDir))
                    quicktypeProcessInfo.WorkingDirectory = this.ProjectDir;
                var command = $"{quicktypeProcessInfo.FileName} {quicktypeProcessInfo.Arguments}";
                Console.WriteLine($"runing command: {command}, on dir {quicktypeProcessInfo.WorkingDirectory}");
                var process = Process.Start(quicktypeProcessInfo);

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"ERROR: The command: '{command}' exited with code {process.ExitCode}. {process.StandardOutput.ReadToEnd()}");
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Trasnformation failed, the underlying error was: " + ex.Message);
                return 1;
            }

        }

        private static void EnsureFolder(string folder)
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
        }

        private async Task<TransformOptions> GetOptions()
        {
            var optionsContent = await File.ReadAllTextAsync(this.OptionsFilePath);
            var options = JsonConvert.DeserializeObject<TransformOptions>(optionsContent);
            return options;
        }
    }
}
