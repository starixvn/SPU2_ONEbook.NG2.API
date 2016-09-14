using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.DTO.CreateAccount;

namespace ONEbook.NG2.API.Utils
{
    /// <summary>
    /// Json converter.
    /// </summary>
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

        /// <summary>
        /// Serializes object to JSON string.
        /// </summary>
        /// <param name="value">Object info.</param>
        /// <returns>String JSON.</returns>
        public static string SerializeObject(object value)
        {
            return _serializer.Serialize(value);
        }

        /// <summary>
        /// Deserializes JSON string to object.
        /// </summary>
        /// <typeparam name="T">Object need to convert JSON to.</typeparam>
        /// <param name="value">JSON string to convert.</param>
        /// <returns>Object info.</returns>
        public static T DeserializeObject<T>(string value)
        {            
            return _serializer.Deserialize<T>(value);
        }
    }
}