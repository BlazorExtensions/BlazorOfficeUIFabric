using System;
using Mono.WebAssembly.Browser.DOM;

namespace CreateElement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var document = new Document();

            // Create a new div element
            var newDiv = document.CreateElement<HTMLDivElement>();

            // and give it some content
            var newContent = document.CreateTextNode("Hi there and greetings!");

            // add the text node to the newly created div
            newDiv.AppendChild(newContent);

            // add the newly created element and its content into the DOM 
            var currentDiv = document.GetElementById("div1"); 

            document.Body.InsertBefore(newDiv, currentDiv); 

        }
    }
}
