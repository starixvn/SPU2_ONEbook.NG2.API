using System;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Interface;
using ONEbook.NG2.API.Utils;

namespace ONEbook.NG2.API
{
    internal class ThirdPartyServices : MarshalByRefObject, IThirdPartyServices
    {
        public Response SyncCustomers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CreateAccount, request);
            response.Result.ResultDetail[0].IsSuccess = 
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.ResultDetail[0].IsSuccess;

            return response;
        }

        public Response ChangeUsersGroup(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ChangeSetting, request);
            response.Result.ResultDetail[0].IsSuccess = 
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.ResultDetail[0].IsSuccess;

            return response;
        }

        public Response CheckIsSyncCustomers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CheckIsSyncCustomers, request);

            return response;
        }

        public Response KickoutMembers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.KickOutMember, request);

            return response;
        }

        public Response ShowRiskAndForecast(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowRiskAndForecast, request);

            return response;
        }
        
        public Response SyncExchangeRates(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.SyncExchangeRate, request);

            return response;
        }

        public Response ShowResult(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowResult, request);

            return response;
        }

        public Response ShowTicketResult(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowTicketResult, request);

            return response;
        }
    }
}