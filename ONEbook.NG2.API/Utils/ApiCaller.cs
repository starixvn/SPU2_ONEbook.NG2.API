using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Fanex.Module.Logs.Services;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.Log;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiCaller
    {
        /// <summary>
        /// Invokes 3rd API.
        /// </summary>
        /// <typeparam name="TRequest">Request object.</typeparam>
        /// <typeparam name="TResponse">Response object.</typeparam>
        /// <param name="function">API function enum.</param>
        /// <param name="request">Request param.</param>
        /// <returns></returns>
        public static TResponse Invoke<TRequest, TResponse>(ApiFunc function, TRequest request)
        {
            var logId = 0L;
            var logger = new APILogger();

            try
            {
                dynamic req = request;
                var param = ApiJsonConvert.SerializeObject(request);
                var xml = JsonToXml(param);
                var actionId = FunctionToId(function.ToString());
                var systemId = req.Auth.SiteId == 2000 ? 3 : 2;
                var userId = req.UserId;
                var custId = GetPropertyValue(param, "ObCustId");
                var result = string.Empty;                
                logId = logger.LogRequest(systemId, NG2Configuration.Instance.ProductId, userId, function.ToString(), custId, actionId, xml);

                var webRequest = CreateRequest<TRequest>(function, request);
                using (var sr = new StreamReader(((HttpWebResponse)webRequest.GetResponse()).GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }

                var errorCode = GetPropertyValue(result, "ErrorCode");
                logger.LogResponse(logId, errorCode, result);
                result = SetPropertyValue(result, "ErrorDescription", errorCode, req.Language);
                dynamic res = ApiJsonConvert.DeserializeObject<TResponse>(result);
                res.UserId = userId;
                res.Language = req.Language;

                return res;
            }
            catch (RemotingTimeoutException te)
            {
                logger.LogResponse(logId, (int)ApiError.RemotingTimeoutException, te.ToString());
                te.Write();
            }
            catch (RemotingException re)
            {
                logger.LogResponse(logId, (int)ApiError.RemotingException, re.ToString());
                re.Write();
            }
            catch (Exception e)
            {
                logger.LogResponse(logId, (int)ApiError.Exception, e.ToString());
                e.Write();
            }

            return Activator.CreateInstance<TResponse>();
        }

        private static XDocument JsonToXml(string jsonString)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                var quotas = new XmlDictionaryReaderQuotas();
                return XDocument.Load(JsonReaderWriterFactory.CreateJsonReader(stream, quotas));
            }
        }

        private static int FunctionToId(string functionName)
        {
            int length = functionName.Length;
            int num = 0;
            for (int index = 1; index <= length; ++index)
            {
                num += (int)functionName[length - index] + index;
            }

            return num;
        }

        private static HttpWebRequest CreateRequest<TRequest>(ApiFunc function, TRequest request)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(NG2Configuration.Instance.Url + "/" + function.ToString());
            var param = ApiJsonConvert.SerializeObject(request);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
            webRequest.ContentLength = param.Length;

            using (var sw = new StreamWriter(webRequest.GetRequestStream()))
            {
                sw.Write(param);
            }

            return webRequest;
        }

        private static int GetPropertyValue(string input, string propertyName)
        {
            var pattern = "(\"" + propertyName + "\":)([^\r\n][0-9]+)";
            var val = 0;
            var regexMatch = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

            if (regexMatch.Success)
            {
                val = Convert.ToInt32(Regex.Replace(regexMatch.Groups[2].ToString(), @"[^a-zA-Z0-9_.]+", string.Empty, RegexOptions.Compiled));
            }

            return val;
        }

        private static string SetPropertyValue(string input, string propertyName, int errorCode, string language)
        {
            var pattern = "(\"" + propertyName + "\":)([^\r\n][a-zA-Z0-9,()?.! ]+)";
            var val = string.Empty;
            var regexMatch = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

            if (regexMatch.Success)
            {
                val = regexMatch.Groups[2].ToString().Replace("\"", string.Empty);
            }

            if (string.IsNullOrWhiteSpace(val))
            {
                return input;
            }

            var resource = ApiResourceHelper.GetResource(((ApiError)errorCode).ToString(), language);
            resource = string.IsNullOrWhiteSpace(resource) ? val : resource;
            input = input.Replace(val, resource);

            return input;
        }
    }
}