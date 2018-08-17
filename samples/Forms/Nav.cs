using System;

using Mono.WebAssembly.Browser.DOM;

namespace Forms
{
    public static class Nav
    {
        static Document Document { get; set; }

        public static void Initialize(Document document)
        {
            Document = document;
            document.Body.OnClick += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => 
            {
                using (var target = args.EventObject.Target.ConvertTo<HTMLElement>())
                {
                    if (target.HasAttribute("data-section"))
                        HandleSectionTrigger(args);
                    else if (target.HasAttribute("data-modal"))
                        HandleModalTrigger(args);
                    else if (target.ClassList.Contains("modal-hide"))
                        HideAllModals();
                        
                }
            };

            ActivateDefaultSection();
            DisplayAbout();
        }

        static void ActivateDefaultSection()
        {
            Document.GetElementById("button-first-form").Click();
        }

        static void DisplayAbout()
        {
            Document.QuerySelector("#about-modal").ClassList.Add("is-shown");
        }

        static void HideAllModals()
        {
            var modals = Document.QuerySelectorAll(".modal.is-shown");
            foreach (var modal in modals)
            {
                modal.ClassList.Remove("is-shown");
            }

            ShowMainContent();
        }

        static void ShowMainContent()
        {
            Document.QuerySelector(".js-nav").ClassList.Add("is-shown");
            Document.QuerySelector(".js-content").ClassList.Add("is-shown");
        }

        static void HandleModalTrigger(DOMEventArgs evt)
        {
            HideAllModals();
            using (var target = evt.EventObject.Target.ConvertTo<HTMLElement>())
            {

                var modalId = $"{target.GetAttribute("data-modal")}-modal";
                Document.GetElementById(modalId).ClassList.Add("is-shown");
            }
        }
        static void HandleSectionTrigger(DOMEventArgs evt)
        {
            HideAllSectionsAndDeselectButtons();

            using (var target = evt.EventObject.Target.ConvertTo<HTMLElement>())
            {


                // Highlight clicked button and show view
                target.ClassList.Add("is-selected");
                // Display the current section
                var sectionId = $"{target.GetAttribute("data-section")}-section";
                Document.GetElementById(sectionId)?.ClassList.Add("is-shown");


                // Save currently active button in localStorage
                var buttonId = target.Id;
                // save this off in a cookie somewhere
                //cookie.settings.set('activeSectionButtonId', buttonId)
            }
        }

        static void HideAllSectionsAndDeselectButtons()
        {
            using (var sections = Document.QuerySelectorAll(".js-section.is-shown"))
            {
                if (sections != null)
                {
                    foreach (var section in sections)
                    {
                        section.ClassList.Remove("is-shown");
                    }
                }

            }

            using (var buttons = Document.QuerySelectorAll(".nav-button.is-selected"))
            {
                if (buttons != null)
                {
                    foreach (var button in buttons)
                    {
                        button.ClassList.Remove("is-selected");
                    }
                }

            }
        }


    }
}
