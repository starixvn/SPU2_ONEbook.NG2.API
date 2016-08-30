using System.Web.Script.Serialization;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiJsonConvert
    {
        public static string SerializeObject(object value)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(value);
        }

        public static T DeserializeObject<T>(string value)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(value);
        }
    }
}