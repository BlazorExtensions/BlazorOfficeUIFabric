using System;

using Mono.WebAssembly.Browser.DOM;


namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.WriteLine("hello world from Invoke!");

            var window = HTMLPage.Window;
            System.Console.WriteLine($"window = {window}");

            if (args != null)
                window.Alert(args);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine($"elapsedMs: {elapsedMs}");

        }
        
    
    }
}
