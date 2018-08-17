using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Fonts
{
    /// <summary>
    /// Font families with fallbacks, for the general regions.
    /// </summary>
    public class LocalizedFontFamilies
    {
        public static string Arabic = $"{LocalizedFontNames.Arabic}";
        public const string ChineseSimplified = "'Microsoft Yahei UI', Verdana, Simsun";
        public const string ChineseTraditional = "'Microsoft Jhenghei UI', Pmingliu";
        public static string Cyrillic = $"'{LocalizedFontNames.Cyrillic}'";
        public static string EastEuropean = $"'{LocalizedFontNames.EastEuropean}'";
        public static string Greek = $"'{LocalizedFontNames.Greek}'";
        public static string Hebrew = $"'{LocalizedFontNames.Hebrew}'";
        public const string Hindi = "'Nirmala UI'";
        public const string Japanese = "'Yu Gothic UI', 'Meiryo UI', Meiryo, 'MS Pgothic', Osaka";
        public const string Korean = "'Malgun Gothic', Gulim";
        public static string Selawik = $"'{LocalizedFontNames.Selawik}'";
        public const string Thai = "'Leelawadee UI Web', 'Kmer UI'";
        public static string Vietnamese = $"'{LocalizedFontNames.Vietnamese}'";
        public static string WestEuropean = $"'{LocalizedFontNames.WestEuropean}'";
    }
}
