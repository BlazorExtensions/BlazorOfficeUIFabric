using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Images
{



    /// <summary>
    /// Image height valye
    ///
    /// Image width valye
    /// </summary>
    public partial struct Size
    {
        public double? Double;
        public string String;

        public static implicit operator Size(double @double) => new Size { Double = @double };
        public static implicit operator Size(string @string) => new Size { String = @string };
        public static explicit operator double(Size value) => value.Double ?? throw new InvalidCastException("The size is not a double value");
        public static explicit operator string(Size value) => value.Double.HasValue ? throw new InvalidCastException("The size is not a string value") : value.String;

        public override string ToString()
        {
            return this.Double.HasValue ? $"{this.Double}" : this.String;
        }
    }
}
