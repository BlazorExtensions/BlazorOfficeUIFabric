using System;
namespace Mono.WebAssembly.Browser.DOM
{
    public partial class EventTarget
    {
        protected internal override object ConvertTo(Type targetType)
        {

            if (targetType.IsAssignableFrom(base.GetType()))
            {
                return this;
            }
            else if (targetType.IsSubclassOf(this.GetType()))
            {
                return CreateJSObjectFrom(targetType, this);
            }

            return base.ConvertTo(targetType);
        }
    }
}
