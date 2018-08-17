using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Mono.WebAssembly.Browser.DOM;

namespace Forms
{
    public static class LinkImports
    {

        // Load our sections from the embedded resources.
        public static void Imports(Document document)
        {
            using (var content = document.QuerySelector(".content"))
            {

                var resourceNames = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
                foreach (var res in resourceNames)
                {

                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string result = reader.ReadToEnd();

                        // JavaScript strings can not have embedded linefeeds.  Instead each string has to be terminated
                        result = Regex.Replace(result, @"\n|\r|\r\n", "\\\n");
                        // We also need to make sure all our quotes can pass or parsing will not work when
                        // setting the content.
                        result = Regex.Replace(result, @"""", "\'");

                        if (res.EndsWith("about.html"))
                            content.InsertAdjacentHtml(InsertPosition.AfterEnd, result);
                        else
                            content.InsertAdjacentHtml(InsertPosition.BeforeEnd, result);
                    }
                }
            }

        }

        // Really Only Chrome supports this.
        public static void ImportsChrome(Document document)
        {

            // Get a collection of all the <link> elements
            var links = document.QuerySelectorAll("link[rel=\'import\']");

            // Loop through all of the <link> elements found
            foreach (var link in links)
            {
                using (var linkElement = link.ConvertTo<HTMLLinkElement>())
                {
                    // Access the contents of the import document by examining the 
                    // import property of the corresponding <link> element
                    // For all imported contents obtain a reference to the <template>
                    var template = linkElement.Import?.QuerySelector<HTMLTemplateElement>(".task-template");
                    // Create a clone of the template’s content using the importNode property and
                    // passing in the content of the template
                    using (var clone = document.ImportNode(template.Content, true))
                    {
                        //Console.WriteLine(linkElement.Href);
                        // Append the newly created cloned template to the content element.
                        if (linkElement.Href.EndsWith("about.html"))
                            document.QuerySelector("body").AppendChild(clone);
                        else
                            document.QuerySelector(".content").AppendChild(clone);
                    }
                }
            }            
        }

    }
    
}
