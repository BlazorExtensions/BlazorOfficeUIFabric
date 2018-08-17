using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Images
{
    public enum ImageLoadState
    {
        /// <summary>
        /// An error has been encountered while loading the image.
        /// </summary>
        Error,

        /// <summary>
        /// Deprecated at v1.3.6, to replace the src in case of errors, use onLoadingStateChange
        /// instead
        /// and rerender the Image with a difference src.
        /// </summary>
        ErrorLoaded,

        /// <summary>
        /// The image has been loaded successfully.
        /// </summary>
        Loaded,

        /// <summary>
        /// The image has not yet been loaded, and there is no error yet.
        /// </summary>
        NotLoaded,
    }
}
