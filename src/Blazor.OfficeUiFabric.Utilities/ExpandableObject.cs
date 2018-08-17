using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Utilities
{
    public class ExpandableObject<T> : Dictionary<string, T>
    {
        protected virtual void SetProperty<TValue>(ref TValue field, TValue value, [CallerMemberName] string propertyName = null)
            where TValue : T
        {
            if (propertyName == null)
                return;
            if (value == default && this.ContainsKey(propertyName))
            {
                this.Remove(propertyName);
            }
            else
            {
                this[propertyName] = field = value;
            }
        }

    }
}
