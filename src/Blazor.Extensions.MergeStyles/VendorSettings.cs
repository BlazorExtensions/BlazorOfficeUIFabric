using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{
    public class VendorSettings
    {
        public const string GET_VENDOR_SETTINGS = "BlazorExtensions.MergeStyles.GetVenedorSettings";
        private static VendorSettings _current;

        public bool IsWebKit { get; set; }

        public bool IsMoz { get; set; }

        public bool IsMs { get; set; }

        public bool IsOpera { get; set; }

        public static async Task<VendorSettings> GetCurrentAsync()
        {

            if (_current == null)
            {
                _current = await JSRuntime.Current.InvokeAsync<VendorSettings>(GET_VENDOR_SETTINGS);
            }
            return _current;
        }

        [JSInvokable]
        public static void SetCurrent(VendorSettings settings)
        {
            _current = settings;

        }
    }
}
