using System;
using System.Collections.Generic;

namespace Blazor.Extensions.MergeStyles
{
    public interface IStyleSet<T> :IStyleSet
    {
       

     
    }

    public interface IStyleSet
    {
        Dictionary<string, object> SubComponentStyles { get; set; }

        void AddStyle(string key, Style styleSet);
    }
}