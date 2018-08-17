using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles
{

    public static class RawConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                IcssRuleEnumConverter.Singleton,
                CssValueConverter.Singleton,
                IFontWeightUnionConverter.Singleton,
                IFontWeightEnumConverter.Singleton,
                FontSizeAdjustUnionConverter.Singleton,
                FontSizeAdjustEnumConverter.Singleton,
                FontStretchConverter.Singleton,
                FontStyleConverter.Singleton,
                FontSmoothingConverter.Singleton,
                WebkitOverflowScrollingConverter.Singleton,
                AlignContentConverter.Singleton,
                AlignItemsConverter.Singleton,
                AlignSelfConverter.Singleton,
                AnimationFillModeConverter.Singleton,
                BackgroundAttachmentConverter.Singleton,
                BackgroundClipConverter.Singleton,
                BoxSizingConverter.Singleton,
                ColumnCountConverter.Singleton,
                ColumnCountEnumConverter.Singleton,
                FillOpacityConverter.Singleton,
                FlexDirectionConverter.Singleton,
                FlexWrapConverter.Singleton,
                JustifyContentConverter.Singleton,
                OverflowConverter.Singleton,
                OverflowWrapConverter.Singleton,
                PositionConverter.Singleton,
                ResizeConverter.Singleton,
                UserSelectConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
