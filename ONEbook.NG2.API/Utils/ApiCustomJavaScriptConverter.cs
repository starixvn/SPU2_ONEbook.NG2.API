using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web.Script.Serialization;

namespace ONEbook.NG2.API.Utils
{
    internal class ApiCustomJavaScriptConverter<T> : JavaScriptConverter where T : new()
    {
        private const string DateFormat = "yyyy-MM-dd HH:mm:ss.fff tt";

        public override IEnumerable<Type> SupportedTypes
        {
            get
            {
                return new[] { typeof(T) };
            }
        }
        
        public static JavaScriptSerializer GetSerializer()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new ApiCustomJavaScriptConverter<T>() });

            return serializer;
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            T p = new T();

            var props = typeof(T).GetProperties();

            foreach (string key in dictionary.Keys)
            {
                var prop = props.Where(t => t.Name == key).FirstOrDefault();
                if (prop != null)
                {
                    if (prop.PropertyType == typeof(DateTime))
                    {
                        prop.SetValue(p, DateTime.ParseExact(dictionary[key] as string, DateFormat, DateTimeFormatInfo.InvariantInfo), null);
                    }
                    else
                    {
                        prop.SetValue(p, dictionary[key], null);
                    }
                }
            }

            return p;
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            T p = (T)obj;
            IDictionary<string, object> serialized = new Dictionary<string, object>();
            var props = typeof(T).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            foreach (PropertyInfo pi in props)
            {
                try
                {
                    if (pi.PropertyType == typeof(DateTime))
                    {
                        serialized[pi.Name] = ((DateTime)pi.GetValue(p, null)).ToString(DateFormat);
                    }
                    else
                    {
                        serialized[pi.Name] = pi.GetValue(p, null);
                    }
                }
                catch
                {
                }
            }

            return serialized;
        }
    }
}