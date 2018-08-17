using System;
using Blazor.Extensions.MergeStyles;
using Blazor.OfficeUiFabric.Styling;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;

namespace Blazor.OfficeUiFabric.Components.Images
{
    public partial class ImageBase : BlazorComponent
    {
        protected ElementRef divRef;
        protected ElementRef imageRef;
        protected ImageCoverStyle _coverStyle = ImageCoverStyle.Portrait;
        protected ElementRef _imageElement;
        protected ElementRef _frameElement;
        //private static string _svgRegex = @"\.svg$";

        /// <summary>
        /// The image source
        /// </summary>
        [Parameter]
        protected string Src { get; set; }

        /// <summary>
        /// The alternative image source
        /// </summary>
        [Parameter]
        protected string Alt { get; set; }

        /// <summary>
        /// The role value
        /// </summary>
        [Parameter]
        protected string Role { get; set; }

        /// <summary>
        /// Accept custom classNames
        /// </summary>
        [Parameter]
        protected ImageStyles ClassNames { get; set; }

        /// <summary>
        /// Image height valye
        /// </summary>
        [Parameter]
        protected Size? Height { get; set; }

        /// <summary>
        /// ImageFit booleans for center, cover, contain, none
        /// </summary>
        [Parameter]
        protected bool? IsCenter { get; set; }

        [Parameter]
        protected bool? IsContain { get; set; }
        [Parameter]
        protected bool? IsCover { get; set; }

        /// <summary>
        /// if true image load is in error
        /// </summary>
        [Parameter]
        protected bool? IsError { get; set; }

        /// <summary>
        /// If true the image is coverStyle landscape instead of portrait
        /// </summary>
        [Parameter]
        protected bool? IsLandscape { get; set; }

        /// <summary>
        /// If true, the image is loaded
        /// </summary>
        [Parameter]
        protected bool? IsLoaded { get; set; }

        [Parameter]
        protected bool? IsNone { get; set; }

        /// <summary>
        /// if true, imageFit is undefined
        /// </summary>
        [Parameter]
        protected bool? IsNotImageFit { get; set; }

        /// <summary>
        /// If true, the image frame will expand to fill its parent container.
        /// </summary>
        [Parameter]
        protected bool? MaximizeFrame { get; set; }

        /// <summary>
        /// If true, fades the image in when loaded.
        /// </summary>
        [Parameter]
        protected bool? ShouldFadeIn { get; set; }

        /// <summary>
        /// If true, the image starts as visible and is hidden on error. Otherwise, the image is
        /// hidden until
        /// it is successfully loaded. This disables shouldFadeIn.
        /// </summary>
        [Parameter]
        protected bool? ShouldStartVisible { get; set; }

        /// <summary>
        /// Accept theme prop.
        /// </summary>
        [Parameter]
        protected Theme Theme { get; set; }

        /// <summary>
        /// Image width valye
        /// </summary>
        [Parameter]
        protected Size? Width { get; set; }


        protected void OnImageLoaded(UIProgressEventArgs args)
        {
            this.OnLoad?.Invoke(args);
            
            throw new NotImplementedException();

        }

        protected void OnImageError(UIErrorEventArgs args)
        {

            throw new NotImplementedException();
        }

        public Action<UIProgressEventArgs> OnLoad { get; set; }

    }
}
