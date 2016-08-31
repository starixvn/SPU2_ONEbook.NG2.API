using System;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Interface;
using ONEbook.NG2.API.Utils;

namespace ONEbook.NG2.API
{
    internal class ThirdPartyServices : MarshalByRefObject, IThirdPartyServices
    {
        public IResponse SyncCustomers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CreateAccount, request);
            response.Result.ResultDetail[0].IsSuccess = 
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.ResultDetail[0].IsSuccess;

            return response;
        }

        public IResponse ChangeUsersGroup(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ChangeSetting, request);
            response.Result.ResultDetail[0].IsSuccess = 
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.ResultDetail[0].IsSuccess;

            return response;
        }

        public IResponse CheckIsSyncCustomers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CheckIsSyncCustomers, request);

            return response;
        }

        public IResponse KickoutMembers(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.KickOutMember, request);

            return response;
        }

        public IResponse ShowRiskAndForecast(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowRiskAndForecast, request);

            return response;
        }
        
        public IResponse SyncExchangeRates(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.SyncExchangeRate, request);

            return response;
        }

        public IResponse ShowResult(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowResult, request);

            return response;
        }

        public IResponse ShowTicketResult(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.ShowTicketResult, request);

            return response;
        }

        public IResponse CreateCurrency(Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CreateCurrency, request);

            return response;
        }
    }
}