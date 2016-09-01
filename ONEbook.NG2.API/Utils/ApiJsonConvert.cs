using System.Web.Script.Serialization;

namespace ONEbook.NG2.API.Utils
{
    public static class ApiJsonConvert
    {
        private static JavaScriptSerializer _serializer;

        static ApiJsonConvert()
        {
            _serializer = new JavaScriptSerializer();
            _serializer.RegisterConverters(new JavaScriptConverter[] { new ApiDateTimeConverter(), new ApiDictionaryConverter() });
        }

        public static string SerializeObject(object value)
        {
            return _serializer.Serialize(value);
        }

        public static T DeserializeObject<T>(string value)
        {            
            return _serializer.Deserialize<T>(value);
        }
    }
}