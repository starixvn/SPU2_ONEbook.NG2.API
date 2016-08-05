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
using Newtonsoft.Json;

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
               
        private void Log(string msg, params object[] arg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }

        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = msg as IMethodCallMessage;
            var methodInfo = methodCall.MethodBase as MethodInfo;
            var json = JsonConvert.SerializeObject(methodCall.InArgs);

            Log("In Dynamic Proxy - Before executing '{0}' params {1}", methodCall.MethodName, json);

            try
            {
                var result = methodInfo.Invoke(_decorated, methodCall.InArgs);                
                var output = JsonConvert.SerializeObject(result);

                // var xml = JsonToXml(json);

                Log("In Dynamic Proxy - After executing '{0}' result {1} ", methodCall.MethodName, output);
                return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
            }
            catch (RemotingTimeoutException te)
            {
                Log("In Dynamic Proxy- Exception {0} executing '{1}'", te, methodCall.MethodName);
                return new ReturnMessage(te, methodCall);
            }
            catch (RemotingException re)
            {
                Log("In Dynamic Proxy- Exception {0} executing '{1}'", re, methodCall.MethodName);
                return new ReturnMessage(re, methodCall);
            }
            catch (Exception e)
            {
                Log("In Dynamic Proxy- Exception {0} executing '{1}'", e, methodCall.MethodName);
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