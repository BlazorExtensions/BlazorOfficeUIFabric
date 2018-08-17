using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Images
{
    public enum ImageFit
    {
        ///
        /// The image is not scaled. The image is centered and cropped within the content box.
        ///
        Center = 0,

        ///
        /// The image is scaled to maintain its aspect ratio while being fully contained within the frame. The image will
        /// be centered horizontally and vertically within the frame. The space in the top and bottom or in the sides of
        /// the frame will be empty depending on the difference in aspect ratio between the image and the frame.
        ///
        Contain = 1,

        ///
        /// The image is scaled to maintain its aspect ratio while filling the frame. Portions of the image will be cropped from
        /// the top and bottom, or from the sides, depending on the difference in aspect ratio between the image and the frame.
        ///
        Cover = 2,

        ///
        /// Neither the image nor the frame are scaled. If their sizes do not match, the image will either be cropped or the
        /// frame will have empty space.
        ///
        None = 3
    }
}
