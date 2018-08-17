using Blazor.OfficeUiFabric.Styling.Fonts;
using Blazor.OfficeUiFabric.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling
{
    public class Theme : ExpandableObject<object>
    {
        private Palette palette;
        private FontStyles fonts;
        private SemanticColors semacticColors;
        private bool disableGlobalCalssNames;
        private Typography typography;

        public Palette Palette { get => this.palette; set => this.SetProperty(ref this.palette,value); }

        public FontStyles Fonts { get => this.fonts; set => this.SetProperty(ref this.fonts,value); }

        public SemanticColors SemacticColors { get => this.semacticColors; set => this.SetProperty(ref this.semacticColors,value); }

        /// <summary>
        /// This setting is for a very narrow use case and you probably don't need to worry about,
        /// unless you share a environment with others that also use fabric.
        /// It is used for disabling global styles on fabric components.This will prevent global
        /// overrides that might have been set by other fabric users from applying to your components.
        /// When you set this setting to `true` on your theme the components in the subtree of your
        /// Customizer will not get the global styles applied to them.
        /// </summary>
        public bool DisableGlobalCalssNames { get => this.disableGlobalCalssNames; set => this.SetProperty(ref this.disableGlobalCalssNames,value); }

        /// <summary>
        /// @internal
        /// The typography property is still in an experimental phase.The intent is the have it
        /// eventually replace IFontStyles in a future release, but it is still undergoing review.
        /// Avoid using it until it is finalized.
        /// </summary>
        public Typography Typography { get => this.typography; set => this.SetProperty(ref this.typography,value); }
        public bool IsInverted { get; internal set; }
    }
}
