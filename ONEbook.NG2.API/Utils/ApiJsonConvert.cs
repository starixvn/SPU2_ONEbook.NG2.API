using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.Utils
{
    public static class ApiJsonConvert
    {
        private static JavaScriptSerializer _serializer;

        static ApiJsonConvert()
        {
            _serializer = new JavaScriptSerializer();
            _serializer.RegisterConverters(new JavaScriptConverter[] 
            {
                new ApiCustomJavaScriptConverter<DateTime>(),
                new ApiCustomJavaScriptConverter<Call>(),
                new ApiCustomJavaScriptConverter<Auth>(),
                new ApiDictionaryConverter()
            });
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