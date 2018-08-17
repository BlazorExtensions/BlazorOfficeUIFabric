using System;
using Mono.WebAssembly.Browser.DOM;
using Mono.WebAssembly.Browser.DOM.Events;
using Mono.WebAssembly;
using System.Threading.Tasks;
using System.Threading;

namespace Hello
{
    public class Program
    {
        static int numTimes = 1;
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.WriteLine("hello world from Main!");

            var document = HTMLPage.Document;

            Console.WriteLine($"Visibility State: {document.VisibilityState}");

            var button = document.CreateElement<HTMLButtonElement>();
            button.TextContent = "Click Me";

            button.OnWheel += (JSObject sender, DOMEventArgs args1) => {
                
                var evt = (WheelEvent)args1.EventObject;
                Console.WriteLine($"We got a wheel wwwhhheeeeee! {evt.DeltaMode}");
            };


            document.Body.AppendChild(button);
            button.OnClick += Button_OnClick;
            button.OnClick += (JSObject sender, DOMEventArgs args1) => {

                var evt = args1.EventObject;

                ((HTMLButtonElement)sender).TextContent = $"We be clicked {numTimes++} times";


            };

            // Make a list
            var ul = document.CreateElement<HTMLUListElement>();
            document.Body.AppendChild(ul);

            var li1 = document.CreateElement<HTMLLIElement>();
            var li2 = document.CreateElement<HTMLLIElement>();
            ul.AppendChild(li1);
            ul.AppendChild(li2);

            ul.OnClick += (JSObject sender, DOMEventArgs args2) => {
                args2.EventObject.Target.ConvertTo<HTMLElement>().SetStyleAttribute("visibility", "hidden");
            };


            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine($"elapsedMs: {elapsedMs}");
        }


        static void Button_OnClick(JSObject sender, DOMEventArgs args)
        {
            var button = (HTMLButtonElement)sender;
            //button.TextContent = "Clicked";

        }

    }
}
