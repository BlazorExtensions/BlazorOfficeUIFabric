using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Images
{
    public enum ImageCoverStyle
    {
        /// <summary>
        /// The image will be shown at 100% height of container and the width will be scaled accordingly
        /// </summary>
        Landscape = 0,
        /// <summary>
        /// The image will be shown at 100% width of container and the height will be scaled accordingly
        /// </summary>
        Portrait = 1
    }
}
