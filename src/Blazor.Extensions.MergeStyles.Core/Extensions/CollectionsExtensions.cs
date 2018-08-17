
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class CollectionsExtensions
    {
        public static string Join<T>(this IEnumerable<T> enumeration, string separator)
        {
            return string.Join(separator, enumeration);
        }

        public static void Add<T>(this ICollection<T> collection, params T[] args)
        {
            foreach (var item in args)
                collection.Add(item);
        }

        public static List<T> Splice<T>(this List<T> source, int index, int count, params T[] args)
        {
            var items = source.GetRange(index, count);
            source.RemoveRange(index, count);
            if (args.Length > 0)
                source.InsertRange(index, args);
            return items;
        }


    }
}
