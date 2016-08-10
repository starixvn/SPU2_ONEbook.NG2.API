using System;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Interface;

namespace ONEbook.NG2.API
{
    internal class ThirdPartyServices : MarshalByRefObject, IThirdPartyServices
    {
        public Response SyncCustomers(Request request)
        {
            return new Response() { TimeStamp = request.TimeStamp };
        }

        public Response ChangeUsersGroup(Request request)
        {
            return new Response();
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
