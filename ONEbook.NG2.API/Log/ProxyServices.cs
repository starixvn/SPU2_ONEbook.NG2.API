using System;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization.Json;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Fanex.Module.Logs.Services;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Utils;

namespace ONEbook.NG2.API.Log
{
    internal class ProxyServices<T> : RealProxy
    {
        private readonly T _decorated;

        [PermissionSet(SecurityAction.LinkDemand)]
        public ProxyServices()
            : base(typeof(T))
        {
            // RealProxy uses the Type to generate a transparent proxy.
            _decorated = (T)Activator.CreateInstance(typeof(T), true);
        }

        private int FunctionToId(string functionName)
        {
            int length = functionName.Length;
            int num = 0;
            for (int index = 1; index <= length; ++index)
            {
                num += (int)functionName[length - index] + index;
            }

            return num;
        }

        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        public override IMessage Invoke(IMessage msg)
        {
            var config = NG2Configuration.Instance;
            var methodCall = msg as IMethodCallMessage;
            var methodInfo = methodCall.MethodBase as MethodInfo;
            var json = ApiJsonConvert.SerializeObject(methodCall.InArgs[0]);
            var req = ApiJsonConvert.DeserializeObject<Request>(json);
            var xml = JsonToXml(json);
            var actionId = FunctionToId(methodCall.MethodName);
            var productId = config.ProductId;
            var systemId = string.IsNullOrWhiteSpace(req.Auth.SiteId) || req.Auth.SiteId.Equals("2000") ? 3 : 2;

            var logger = new APILogger();
            var logId = 0L;

            try
            {                
                logId = logger.LogRequest(systemId, productId, req.Call.UserId, methodCall.MethodName, req.Call.CustIds[0], actionId, xml);

                var result = methodInfo.Invoke(_decorated, methodCall.InArgs);                
                var output = ApiJsonConvert.SerializeObject(result);
                var response = ApiJsonConvert.DeserializeObject<Response>(output);
                var returnCode = response.Result.ResultDetail.Count > 0 ? 
                    (response.Result.ResultDetail[0].IsSuccess ? 0 : response.Result.ResultDetail[0].ErrorCode) : 0;

                logger.LogResponse(logId, returnCode, output);

                return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
            }
            catch (RemotingTimeoutException te)
            {
                logger.LogResponse(logId, (int)ApiError.RemotingTimeoutException, te.ToString());
                te.Write();

                return new ReturnMessage(te, methodCall);
            }
            catch (RemotingException re)
            {
                logger.LogResponse(logId, (int)ApiError.RemotingException, re.ToString());
                re.Write();

                return new ReturnMessage(re, methodCall);
            }
            catch (Exception e)
            {
                logger.LogResponse(logId, (int)ApiError.Exception, e.ToString());
                e.Write();

                return new ReturnMessage(e, methodCall);
            }
        }

        private XDocument JsonToXml(string jsonString)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                var quotas = new XmlDictionaryReaderQuotas();
                return XDocument.Load(JsonReaderWriterFactory.CreateJsonReader(stream, quotas));
            }
        }
    }
}