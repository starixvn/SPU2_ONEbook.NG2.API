using Newtonsoft.Json;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiJsonConvert
    {
        public static string SerializeObject(object value, ApiContractResolver resolver)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings() { ContractResolver = resolver, NullValueHandling = NullValueHandling.Ignore });
        }

        public static T DeserializeObject<T>(string value, ApiContractResolver resolver)
        {
            return JsonConvert.DeserializeObject<T>(value, new JsonSerializerSettings() { ContractResolver = resolver, NullValueHandling = NullValueHandling.Ignore });
        }
    }
}