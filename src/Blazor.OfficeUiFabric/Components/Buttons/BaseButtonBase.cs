using Blazor.OfficeUiFabric.Styling;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Buttons
{
    public class BaseButtonBase : BlazorComponent
    {
        public ElementRef ButtonRef { get; set; }

        /// <summary>
        ///  If provided, this component will be rendered as an anchor.
        /// </summary>
        [Parameter]
        protected string Href { get; set; }

        /// <summary>
        ///  Changes the visual presentation of the button to be emphasized (if defined)
        /// </summary>
        /// <value>
        /// false
        /// </value>
        [Parameter]
        protected bool Primary { get; set; }

        /// <summary>
        /// Whether the button is disabled
        /// </summary>
        ///
        [Parameter]
        protected bool Disabled { get; set; }


        /// <summary>
        ///  Whether the button can have focus in disabled mode
        /// </summary>
        ///
        [Parameter]
        protected bool AllowDisabledFocus { get; set; }


        /// <summary>
        /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
        /// </summary>
        [Parameter]
        protected bool PrimaryDisabled { get; set; }


        /// <summary>
        ///  Custom styling for individual elements within the button DOM.
        /// </summary>
        [Parameter]
        protected ButtonStyles Styles { get; set; }


        /// <summary>
        /// Theme provided by HOC.
        /// </summary>
        [Parameter]
        protected Theme Theme { get; set; }

        /// <summary>
        ///  Whether the button is checked
        /// </summary>
        [Parameter]
        protected bool Checked { get; set; }

        /// <summary>
        /// If provided, additional class name to provide on the root element. 
        /// </summary>
        protected string ClassName { get; set; }

        /// <summary>
        /// The aria label of the button for the benefit of screen readers.
        /// </summary>
        ///
        [Parameter]
        protected string AriaLabel { get; set; }

        /// <summary>
        ///  Detailed description of the button for the benefit of screen readers.
        ///
        ///  Besides the compound button, other button types will need more information provided to screen reader.
        /// </summary>
        [Parameter]
        protected string AriaDescripton { get; set; }

        /// <summary>
        /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
        /// </summary>
        [Parameter]
        protected bool AriaHidden { get; set; }

        /// <summary>
        /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
        /// </summary>
        [Parameter]
        protected string Text { get; set; }


    

        public void Focus()
        {

        }

        public void DismissMenu()
        {

        }

        public void OpenMenu(bool shouldFocusOnContainer, bool shouldFocusOnMount)
        {

        }
    }
}
