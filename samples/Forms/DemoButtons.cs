using System;

using Mono.WebAssembly.Browser.DOM;

namespace Forms
{
    public static class DemoButtons
    {
        static Document Document { get; set; }

        public static void Initialize(Document document)
        {
            

            using (var demoBtns = document.QuerySelectorAll(".js-container-target"))
            {
                foreach (var btnElement in demoBtns)
                {
                    using (var btn = btnElement.ConvertTo<HTMLElement>())
                    {
                        btn.OnClick += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => 
                        {
                            using (var target = args.EventObject.Target.ConvertTo<HTMLElement>())
                            {
                                using (var parent = args.EventObject.Target.ConvertTo<HTMLElement>().ParentElement)
                                {
                                    // Toggles the "is-open" class on the demo's parent element.
                                    parent.ClassList.Toggle("is-open");

                                    // Save this state off into some type of cookie 
                                    //if (parent.ClassList.Contains("is-open"))
                                    //    settings.set("activeDemoButtonId", target.Id);
                                    //else
                                        //settings.delete("activeDemoButtonId");
                                }
                            }                                
                        };
                    }
                }
                
            }
        }

    }
}
