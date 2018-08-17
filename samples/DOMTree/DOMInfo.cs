using System;
using Mono.WebAssembly.Browser.DOM;

namespace DOMTree
{
    public class DOMInfo
    {

        string elementTree = string.Empty;

        /// <summary>
        /// Default entry into managed code.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void Invoke(string input)
        {
            var document = HTMLPage.Document;
            // Get a reference to the top-level <html> element.
            var element = document.DocumentElement;
            // Process the starting element reference
            ProcessElement(element, 0);
            Console.WriteLine(elementTree);
            
        }  

        private void ProcessElement(Element element, int indent)
        {
            // Ignore comments.
            if (element.TagName == "!") return;

            // Indent the element to help show different levels of nesting.
            elementTree += new String(' ', indent * 4);

            // Display the tag name.
            elementTree += "<" + element.TagName;

            // Only show the id attribute if it's set.
            if (element.Id != "") elementTree += " id=\"" + element.Id + "\"";
            elementTree += ">\n";

            // Process all the elements nested inside the current element.
            foreach (var childElement in element.Children)
            {
                ProcessElement(childElement, indent + 1);
            }
        }
    
    }
}
