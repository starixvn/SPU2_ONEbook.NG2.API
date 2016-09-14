using System;
using System.Globalization;
using System.Resources;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiResourceHelper
    {
        private static ResourceManager resourceManager;

        static ApiResourceHelper()
        {
            resourceManager = resourceManager ?? new ResourceManager(Type.GetType("ONEbook.NG2.API.Resources.ErrorCode"));
        }

        public static string GetResource(string key, string language)
        {            
            return resourceManager.GetObject(key, new CultureInfo(language)) as string;
        }
    }
}