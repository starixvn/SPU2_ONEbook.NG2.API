using System;
using System.IO;
using System.Net;
using Fanex.Module.Logs.Services;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiCaller
    {
        public static Response Invoke(ApiFunction.Func function, Request request)
        {
            try
            {
                var config = NG2Configuration.Instance;
                var webRequest = (HttpWebRequest)WebRequest.Create(config.Url + "/" + function.ToString());
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";

                var param = ApiJsonConvert.SerializeObject(request, new ApiContractResolver());
                webRequest.ContentLength = param.Length;
                
                using (var sw = new StreamWriter(webRequest.GetRequestStream()))
                {
                    sw.Write(param);
                }

                var result = string.Empty;
                using (var sr = new StreamReader(((HttpWebResponse)webRequest.GetResponse()).GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }

                var output = ApiJsonConvert.DeserializeObject<Response>(result, new ApiContractResolver());

                return output;
            }
            catch (Exception ex)
            {
                ex.Write();

                return new Response();
            }
        }
    }
}