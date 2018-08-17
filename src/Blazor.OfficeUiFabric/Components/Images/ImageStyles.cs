using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Images
{
    public class ImageStyles : StyleSet<ImageStyles>
    {
        /// <summary>
        /// Style set for the img element.
        /// </summary>
        private Style image;


        /// <summary>
        /// Style set for the root div element.
        /// </summary>
        public Style Image { get => this.image; set => SetProperty(ref this.image, value); }
    }
}
