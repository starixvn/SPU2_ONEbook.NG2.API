using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace ONEbook.NG2.API.Utils
{
    internal class ApiDateTimeConverter : JavaScriptConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new List<Type>() { typeof(DateTime), typeof(DateTime?) }; }
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            if (obj == null)
            {
                return result;
            }

            result["DateTime"] = ((DateTime)obj).ToString("yyyy-MM-dd HH:mm:ss.fff tt");

            return result;
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            if (dictionary.ContainsKey("DateTime"))
            {
                return new DateTime(long.Parse(dictionary["DateTime"].ToString()), DateTimeKind.Unspecified);
            }

            return null;
        }
    }
}