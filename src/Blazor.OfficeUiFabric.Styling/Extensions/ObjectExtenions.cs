using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Styling.Extensions
{
    public static class ObjectExtenions
    {
        public static void CopyValues<T>(this T target, T source)

        {
            Type t = typeof(T);

            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(source, null);
                if (value != null)
                    prop.SetValue(target, value, null);
            }
        }

        public static T MergeValues<T>(this T target, params T[] sources)
        {

            Type t = typeof(T);

            var properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanRead && p.CanWrite);
            foreach (var source in sources)
            {
                if (source == null)
                    continue;

                foreach (var prop in properties)
                {
                    var value = prop.GetValue(source);
                    if (value != null)
                        prop.SetValue(target, value);
                }
            }
            return target;
        }
    }
}
