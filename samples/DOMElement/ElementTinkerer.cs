using System;
using System.Linq;
using Mono.WebAssembly.Browser.DOM;

namespace DOMElement
{
    public class ElementTinkerer
    {

        /// <summary>
        /// Default entry into managed code.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void Invoke(string input)
        {
            // Get a reference to the HTML DOM document.
            var document = HTMLPage.Document;

            // Get a reference to the body element.
            var loading = document.GetElementById("loading");
            loading.Hidden = true;

            // Get a reference to the body element.
            var body = document.GetElementById("docBody");
            // Create a <main> type element
            var mainElement = document.CreateElement("main");
            // Append the newly created element to the page DOM
            body.AppendChild(mainElement);

            // Get a collection of all the <main> type element in the page and using
            // Linq get the first of the collection.
            var content = document.GetElementsByTagName("main").First();

            // Get a collection of all the <link> elements
            var links = document.QuerySelectorAll("link[rel=\'import\']");

            // Loop through all of the <link> elements found
            foreach (var link in links)
            {
                // Access the contents of the import document by examining the 
                // import property of the corresponding <link> element
                // For all imported contents obtain a reference to the <template>
                var template = link.As<HTMLLinkElement>().Import.QuerySelector<HTMLTemplateElement>(".task-template");
                // Create a clone of the template’s content using the importNode property and
                // passing in the content of the template
                var clone = document.ImportNode(template.Content, true);

                // Append the newly created cloned template to the content element.
                content.AppendChild(clone);
            }            
        }  

    }
}
