using System;
using System.Collections.Generic;
using ONEbook.NG2.API.Configuration;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Interface;

namespace ONEbook.NG2.API
{
    internal class ThirdPartyServices : MarshalByRefObject, IThirdPartyServices
    {
        public Response SyncCustomers(Request request)
        {
            var response = new Response()
            {
                TimeStamp = request.TimeStamp,
                Result = new Result
                {
                    Seq = request.Call.Seq,
                    ResultDetail = new List<ResultDetail>()
                }
            };

            var success = NG2Configuration.Instance.Debug == "1" ? NG2Configuration.Instance.Success.Equals("1") ? true : false : false;
            foreach (var custId in request.Call.CustIds)
            {
                response.Result.ResultDetail.Add(new ResultDetail
                {
                    CustId = custId,
                    IsSuccess = success,
                    ErrorCode = success ? 0 : 1,
                    ErrorDescription = success ? string.Empty : "Synchronizes to 3rd failed. Timeout exception."
                });

            }
            
            return response;
        }

        public Response ChangeUsersGroup(Request request)
        {
            var success = NG2Configuration.Instance.Debug == "1" ? NG2Configuration.Instance.Success.Equals("1") ? true : false : false;
            var response = new Response()
            {
                TimeStamp = request.TimeStamp,
                Result = new Result
                {
                    Seq = request.Call.Seq,
                    ResultDetail = new List<ResultDetail>()
                    {
                        new ResultDetail
                        {
                            CustId = request.Call.CustIds[0],
                            IsSuccess = success,
                            ErrorCode = success ? 0 : 1,
                            ErrorDescription = success ? string.Empty : "Synchronizes to 3rd failed. Timeout exception."
                        }
                    }
                }
            };

            return response;
        }

        public Response CheckIsSyncCustomers(Request request)
        {
            return new Response();
        }

        public Response KickoutMembers(Request request)
        {
            return new Response();
        }

        public Response ShowRiskAndForecast(Request request)
        {
            return new Response();
        }

        public Response ShowSchedule(Request request)
        {
            return new Response();
        }

        public Response SyncExchangeRates(Request request)
        {
            return new Response();
        }

        public Response ShowResult(Request request)
        {
            return new Response();
        }

        public Response ShowTicketResult(Request request)
        {
            return new Response();
        }
    }
}
