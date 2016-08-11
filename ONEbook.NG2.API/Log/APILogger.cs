using System;
using System.Collections;
using System.Xml.Linq;
using Fanex.Data;
using Fanex.Module.Logs.Services;

namespace ONEbook.NG2.API.Log
{
    internal class APILogger
    {
        public long LogRequest(int systemId, int productId, int userId, string functionName, int custId, int actionId, XDocument request)
        {
            using (var objDb = new ObjectDb("WriteLog_UserLog_ExternalAPI_Ins"))
            {
                try
                {
                    var param = new Hashtable();
                    param.Add("systemid", systemId);
                    param.Add("productid", productId);
                    param.Add("userid", userId);
                    param.Add("funcname", functionName);
                    param.Add("custid", custId);
                    param.Add("actionid", actionId);
                    param.Add("trackingvalue", request.ToString());
                    param.Add("logid", 0L);

                    objDb.AssignParamValues(param);
                    objDb.ExecuteNonQuery();

                    return (long)objDb.GetParameterValue("logid");
                }
                catch (Exception ex)
                {
                    ex.Write();
                }

                return 0;   
            }
        }

        public bool LogResponse(long logId, int returnCode, string response)
        {
            using (var objDb = new ObjectDb("WriteLog_UserLog_ExternalAPI_UpdResponse"))
            {
                try
                {
                    var param = new Hashtable();
                    param.Add("logid", logId);
                    param.Add("returncode", returnCode);
                    param.Add("returnvalue", response);

                    objDb.AssignParamValues(param);
                    objDb.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    ex.Write();
                }

                return false;
            }            
        }
    }
}