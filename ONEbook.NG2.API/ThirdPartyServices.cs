using System;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO.CreateAccount;
using ONEbook.NG2.API.Interface;
using ONEbook.NG2.API.Utils;

namespace ONEbook.NG2.API
{
    internal class ThirdPartyServices : MarshalByRefObject, IThirdPartyServices
    {
        public DTO.CreateAccount.Response SyncCustomers(DTO.CreateAccount.Request request)
        {
            var response = ApiCaller.Invoke<Request, Response>(ApiFunc.CreateAccount, request);
            response.Result.IsSuccess = 
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }
        
        public DTO.CheckIsSyncCustomer.Response CheckIsSyncCustomers(DTO.CheckIsSyncCustomer.Request request)
        {
            var response = ApiCaller.Invoke<DTO.CheckIsSyncCustomer.Request, DTO.CheckIsSyncCustomer.Response>(ApiFunc.CheckIsSyncCustomers, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }
        
        public DTO.ShowRiskAndForecast.Response ShowRiskAndForecast(DTO.ShowRiskAndForecast.Request request)
        {
            var response = ApiCaller.Invoke<DTO.ShowRiskAndForecast.Request, DTO.ShowRiskAndForecast.Response>(ApiFunc.ShowRiskAndForecast, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }
        
        public DTO.SyncExchangeRate.Response SyncExchangeRates(DTO.SyncExchangeRate.Request request)
        {
            var response = ApiCaller.Invoke<DTO.SyncExchangeRate.Request, DTO.SyncExchangeRate.Response>(ApiFunc.SyncExchangeRate, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }

        public DTO.ShowResult.Response ShowResult(DTO.ShowResult.Request request)
        {
            var response = ApiCaller.Invoke<DTO.ShowResult.Request, DTO.ShowResult.Response>(ApiFunc.ShowResult, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }

        public DTO.ShowTicketResult.Response ShowTicketResult(DTO.ShowTicketResult.Request request)
        {
            var response = ApiCaller.Invoke<DTO.ShowTicketResult.Request, DTO.ShowTicketResult.Response>(ApiFunc.ShowTicketResult, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }

        public DTO.CreateCurrency.Response CreateCurrency(DTO.CreateCurrency.Request request)
        {
            var response = ApiCaller.Invoke<DTO.CreateCurrency.Request, DTO.CreateCurrency.Response>(ApiFunc.CreateCurrency, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }

        public DTO.ShowParlayDetail.Response ShowParlayDetail(DTO.ShowParlayDetail.Request request)
        {
            var response = ApiCaller.Invoke<DTO.ShowParlayDetail.Request, DTO.ShowParlayDetail.Response>(ApiFunc.ShowParlayDetail, request);
            response.Result.IsSuccess =
                NG2Configuration.Instance.Debug == "1" && NG2Configuration.Instance.Success == "1" ? true : response.Result.IsSuccess;

            return response;
        }
    }
}