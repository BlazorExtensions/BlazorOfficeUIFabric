using Mono.WebAssembly.Browser.DOM;
using System;
using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling
{
    public class ThemeState
    {
        public ThemeState()
        {
            this.RegisteredStyles = new List<StyleRecord>();
            this.RegisteredThemableStyles = new List<StyleRecord>();
            this.RunState = new RunState();
            this.Performance = new Measurement();

        }
        public Theme Theme { get; set; }

        public HTMLStyleElement LastStyleElement { get; set; }

        /// <summary>
        /// Records of already registered non-themable styles
        /// </summary>
        public ICollection<StyleRecord> RegisteredStyles { get; set; }

        /// <summary>
        /// Records of already registered themable styles
        /// </summary>
        public ICollection<StyleRecord> RegisteredThemableStyles { get; set; }

        public Measurement Performance { get; set; }

        public RunState RunState { get; set; }

        public void Deconstruct(out RunState runState, out Measurement performance, out Theme theme)
        {
            runState = this.RunState;
            performance = this.Performance;
            theme = this.Theme;
        }

        public Action<string, IEnumerable<ThemingInstruction>> LoadAction { get; set; }


        internal bool LoadStyle(string styleString, IEnumerable<ThemingInstruction> styles)
        {
            if (this.LoadAction != null)
            {
                this.LoadAction.Invoke(styleString, styles);
                return false;
            }
            return true;
        }
    }
}