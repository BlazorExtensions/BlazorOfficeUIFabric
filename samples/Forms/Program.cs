using System;
using Mono.WebAssembly.Browser.DOM;

namespace Forms
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Get a reference to the body element.
            var document = HTMLPage.Document;

            // Hide the loading label
            document.GetElementById("loading").Remove();

            // For cross browser support we can not use HTMLLinkElement Import
            // so the divs are within the code itself.
            LinkImports.Imports(document);

            Nav.Initialize(document);
            DemoButtons.Initialize(document);

        }

    }
}
