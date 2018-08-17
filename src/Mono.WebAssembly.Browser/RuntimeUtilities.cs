using System;
using System.Reflection;

namespace Mono.WebAssembly
{

    public static class RuntimeUtilities
    {

        private static double nextUID = 1;

        static Int64 MinDateTimeTicks = 621355968000000000; // (new DateTime(1970, 1, 1, 0, 0, 0)).Ticks;

        // dummy Main so we can exec from mono
        static public int Main()
        {
            return 0;
        }

        static public Exception NormalizeException(Exception e)
        {
            AggregateException aggregate = e as AggregateException;
            if (aggregate != null && aggregate.InnerExceptions.Count == 1)
            {
                e = aggregate.InnerExceptions[0];
            }
            else {
                TargetInvocationException target = e as TargetInvocationException;
                if (target != null && target.InnerException != null)
                {
                    e = target.InnerException;
                }
            }

            return e;
        }

        static public DateTime CreateDateTime(double ticks)
        {
            return new DateTime((Int64)ticks * 10000 + MinDateTimeTicks, DateTimeKind.Utc);
        }

        static public Func<Object, Object> GetFunc(string assemblyFile, string typeName, string methodName)
        {
            Console.WriteLine($"CS::GetFunc: AssemblyFile: {assemblyFile} | TypeName: {typeName} | MethodName: {methodName} ");
            try {
                var assembly = Assembly.Load(assemblyFile);
                var wrap = ClrFuncReflectionWrap.Create(assembly, typeName, methodName);
                Console.WriteLine("CS::GetFunc::End");
                return new Func<Object, Object>(wrap.Call);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"CS::GetFunc::Exception - {exc.Message}");
                throw exc;
            }

        }

        static public string ObjectToString(object o)
        {
            return o.ToString();
        }

        static public double Int64ToDouble(long i64)
        {
            return (double)i64;
        }

        static public string TryConvertPrimitiveOrDecimal(object obj)
        {
            Type t = obj.GetType();
            if (t.IsPrimitive || typeof(Decimal) == t)
            {
                IConvertible c = obj as IConvertible;
                return c == null ? obj.ToString() : c.ToString();
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This an id that is unique over the lifetime of the process. It changes
        /// at each access.
        /// </summary>
        internal static double NextUID
        {
            get
            {
                return nextUID++;
            }
        }

        // This is simple right now and will include FlagsAttribute later.
        internal static Enum EnumFromExportContract(Type enumType, object value)
        {

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", nameof(enumType));
            }

            if (value is string)
            {

                var fields = enumType.GetFields();
                foreach (var fi in fields)
                {
                    ExportAttribute[] attributes =
                        (ExportAttribute[])fi.GetCustomAttributes(typeof(ExportAttribute), false);

                    var enumConversionType = ConvertEnum.Default;

                    object contractName = null;

                    if (attributes != null && attributes.Length > 0)
                    {
                        enumConversionType = attributes[0].EnumValue;
                        if (enumConversionType != ConvertEnum.Numeric)
                            contractName = attributes[0].ContractName;

                    }

                    if (contractName == null)
                        contractName = value;

                    switch (enumConversionType)
                    {
                        case ConvertEnum.ToLower:
                            contractName = contractName.ToString().ToLower();
                            break;
                        case ConvertEnum.ToUpper:
                            contractName = contractName.ToString().ToUpper();
                            break;
                        case ConvertEnum.Numeric:
                            contractName = (int)Enum.Parse(value.GetType(), contractName.ToString());
                            break;
                        default:
                            contractName = fi.Name.ToString();
                            break;
                    }

                    if (contractName.ToString() == value.ToString())
                    {
                        return (Enum)Enum.Parse(enumType, fi.Name);
                    }

                }

            }
            else
            {
                return (Enum)Enum.ToObject(enumType, value);
            }

            return null;
        }

        // This is simple right now and will include FlagsAttribute later.
        internal static object EnumToExportContract(Enum value)
        {

            FieldInfo fi = value.GetType().GetField(value.ToString());

            ExportAttribute[] attributes =
                (ExportAttribute[])fi.GetCustomAttributes(typeof(ExportAttribute), false);

            var enumConversionType = ConvertEnum.Default;

            object contractName = null;

            if (attributes != null && attributes.Length > 0)
            {
                enumConversionType = attributes[0].EnumValue;
                if (enumConversionType != ConvertEnum.Numeric)
                    contractName = attributes[0].ContractName;

            }

            if (contractName == null)
                contractName = value;

            switch (enumConversionType)
            {
                case ConvertEnum.ToLower:
                    contractName = contractName.ToString().ToLower();
                    break;
                case ConvertEnum.ToUpper:
                    contractName = contractName.ToString().ToUpper();
                    break;
                case ConvertEnum.Numeric:
                    contractName = (int)Enum.Parse(value.GetType(), contractName.ToString());
                    break;
                default:
                    contractName = fi.Name.ToString();
                    break;
            }

            return contractName;
        }

    }
}