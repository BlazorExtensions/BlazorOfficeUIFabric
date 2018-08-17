using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mono.WebAssembly
{
    public class JSObject : IDisposable
    {
        int handle;
        public int Handle { get => this.handle; private set { this.handle = value; } }

        // Flag: Has Dispose already been called?
        bool disposed = false;

        internal JSObject managedParentObject;

        // Inheritance Chain
        protected JSObject ManagedParentObject
        {
            get { return this.managedParentObject; }
        }

        internal JSObject() { }

        internal JSObject(int reference)
        {
            this.Handle = reference;
        }

        protected JSObject(string globalName) : this(GetGlobal(globalName))
        {

        }

        protected static int GetGlobal(string str)
        {
            var res = Runtime.ExecuteJavaScript("MonoWasmBrowserAPI.mono_wasm_val_global(\"" + str + "\");");
            return (res == null || res == "undefined") ? -1 : Int32.Parse(res);
        }

        protected T GetProperty<T>(string expr)
        {
            var getPropOf = "MonoWasmBrowserAPI.mono_wasm_get_property(" + this.Handle + ",\"" + expr + "\")";
            object propertyValue = null;
            var type = typeof(T);
            if (type.IsSubclassOf(typeof(JSObject)) || typeof(JSObject) == type)
            {
                propertyValue = Runtime.ExecuteJavaScript("MonoWasmBrowserAPI.mono_wasm_register_obj(" 
                    + getPropOf
                    + ");");
            }
            else 
                propertyValue = Runtime.ExecuteJavaScript(getPropOf);

            return UnWrapObject<T>(propertyValue);
            
        }

        protected void SetProperty<T>(string expr, T value, bool createIfNotExists = true, bool hasOwnProperty = false)
        {
            var setPropOf = "MonoWasmBrowserAPI.mono_wasm_set_property(" + this.Handle + ",\"" + expr + "\",";
            var setPropOptions = ", " + (createIfNotExists ? "true" : "false") + ", " + (hasOwnProperty ? "true" : "false") + ")";
            var objValue = WrapObject<T>(value);
            Runtime.ExecuteJavaScript(setPropOf + objValue + setPropOptions);

        }

        private string WrapObject(object obj)
        {

            var type = obj.GetType();
            if (type.IsPrimitive || typeof(Decimal) == type)
            {
                IConvertible c = obj as IConvertible;
                if (typeof(bool) == type)
                {
                    return c == null ? obj.ToString().ToLowerInvariant() : c.ToString().ToLowerInvariant();
                }
                else
                {
                    return c == null ? obj.ToString() : c.ToString();
                }
            }
            else if (type.IsEnum)
            {
                var enumValue = RuntimeUtilities.EnumToExportContract((Enum)obj);
                return enumValue == null ? "null" : $"\"{enumValue.ToString()}\"";
            }
            else if (type == typeof(string))
            {
                return obj == null ? "null" : $"\"{obj.ToString()}\"";
            }
            else if (type.IsSubclassOf(typeof(JSObject)) || type == typeof(JSObject))
            {
                if (obj == null)
                {
                    return "null";
                }
                else
                {
                    return "MonoWasmBrowserAPI.mono_wasm_require_handle(" + ((JSObject)(object)obj).Handle + ")";
                }
            }
            return "";
        }

        private string WrapObject<T>(object obj)
        {

            var type = typeof(T);
            if (type.IsPrimitive || typeof(Decimal) == type)
            {
                IConvertible c = obj as IConvertible;
                if (typeof(bool) == type)
                {
                    return c == null ? obj.ToString().ToLowerInvariant() : c.ToString().ToLowerInvariant();
                }
                else
                {
                    return c == null ? obj.ToString() : c.ToString();
                }
            }
            else if (type.IsEnum)
            {
                var enumValue = RuntimeUtilities.EnumToExportContract((Enum)obj);
                return enumValue == null ? "null" : $"\"{enumValue.ToString()}\"";
            }
            else if (type == typeof(string))
            {
                return obj == null ? "null" : $"\"{obj.ToString()}\"";
            }
            else if (type.IsSubclassOf(typeof(JSObject)) || type == typeof(JSObject))
            {
                if (obj == null)
                {
                    return "null";
                }
                else
                {
                    return "MonoWasmBrowserAPI.mono_wasm_require_handle(" + ((JSObject)(object)obj).Handle + ")";
                }
            }
            return "";
        }

        object UnWrapObject(Type type, object obj)
        {
            if (type.IsPrimitive || typeof(Decimal) == type)
            {
                return Convert.ChangeType(obj, type);
            }
            else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {

                var conv = System.ComponentModel.TypeDescriptor.GetConverter(type);

                if (!conv.CanConvertFrom(obj.GetType()))
                {
                    throw new NotSupportedException();
                }

                if (conv.IsValid(obj))
                {
                    return conv.ConvertFrom(obj);
                }

                throw new InvalidCastException();
            }
            else if (type.IsEnum)
            {
                return RuntimeUtilities.EnumFromExportContract(type, obj);
            }
            else if (type == typeof(string))
            {
                return obj;
            }
            else if (type.IsSubclassOf(typeof(JSObject)) || type == typeof(JSObject))
            {
                if (obj == null)
                    return (object)null;

                var jsobject = obj.ToString();

                var jsobjectnew = type.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                                null, new Type[] { typeof(Int32) }, null);

                return jsobjectnew.Invoke(new object[] { (jsobject == null) ? -1 : Int32.Parse(jsobject) });

            }
            else if (type is object)
            {
                // called via invoke
                if (obj == null)
                    return (object)null;
                else
                    throw new NotSupportedException($"Type {type} not supported yet.");

            }
            else
            {
                throw new NotSupportedException($"Type {type} not supported yet.");
            }


        }

        T UnWrapObject<T>(object obj)
        {

            return (T)UnWrapObject(typeof(T), obj);
        }

        protected object InvokeMethod(Type type, string methodName, params object[] args)
        {
            var wrappedParms = new List<string>();

            var invokeWith = "MonoWasmBrowserAPI.mono_wasm_invoke(" + this.Handle + ",\"" + methodName + "\", [ ";
            var invokeWithEnd = "])";

            for (int x = 0; x < args.Length; x++)
            {
                if (x > 0)
                    invokeWith += ", ";
                invokeWith += WrapObject(args[x]);
            }

            invokeWith += invokeWithEnd;

            if (type.IsSubclassOf(typeof(JSObject)) || type == typeof(JSObject))
            {
                invokeWith = "MonoWasmBrowserAPI.mono_wasm_register_obj("
                    + invokeWith
                    + ");";

            }

            var res = Runtime.ExecuteJavaScript(invokeWith);


            return UnWrapObject(type, res);
        }

        protected T InvokeMethod<T>(string methodName, params object[] args)
        {
            return (T)InvokeMethod(typeof(T), methodName, args);
        }

        protected void FreeHandle ()
        {
            Runtime.ExecuteJavaScript("MonoWasmBrowserAPI.mono_wasm_free_handle(" + this.Handle + ");");
        }


        public override bool Equals(System.Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.Handle == (obj as JSObject).Handle;
        }

        public override int GetHashCode()
        {
            return this.Handle;
        }

		public T ConvertTo<T>()
		{
			return (T)((object)this.ConvertTo(typeof(T)));
		}

		protected internal virtual object ConvertTo(Type targetType)
		{
			if (targetType.IsAssignableFrom(base.GetType()))
			{
				return this;
			}
            throw new ArgumentException($"Conversion Failed : {this.GetType()} to {targetType}");
		}


        static internal T CreateJSObject<T>(int objHandle)
        {

            var type = typeof(T);
            var jsobjectnew = typeof(T).GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                            null, new Type[] { typeof(Int32) }, null);

            return (T)jsobjectnew.Invoke(new object[] { objHandle });

        }

        static internal object CreateJSObjectFrom(Type targetType, JSObject parentObject, bool inheritFrom = true)
        {

            var jsObjectConstructor = targetType.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                null, new Type[] { typeof(Int32) }, null);

            var newJSObject = jsObjectConstructor.Invoke(new object[] { parentObject.handle });
            if (inheritFrom)
                ((JSObject)newJSObject).managedParentObject = parentObject;

            return newJSObject;

        }

        public override string ToString()
        {
            return $"JS Object {this.Handle}";
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;

            if (disposing)
            {

                // Free any other managed objects here.
                //
                FreeHandle();
                this.handle = -1;
            }

            // Free any unmanaged objects here.
            //
            this.disposed = true;
        }

    }
}