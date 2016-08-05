using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API
{
    public class Services
    {
        private readonly ThirdPartyServices _proxy;

        public Services()
        {
            _proxy = WrapperServices<ThirdPartyServices>.Wrap();            
        }
        
        public Response SyncCustomers(Request request)
        {
            return _proxy.SyncCustomers(request);
        }

        public Response ChangeUsersGroup(Request request)
        {
            return _proxy.ChangeUsersGroup(request);
        }

        public Response CheckIsSyncCustomers(Request request)
        {
            return _proxy.CheckIsSyncCustomers(request);
        }

        public Response KickoutMembers(Request request)
        {
            return _proxy.KickoutMembers(request);
        }

        public Response ShowRiskAndForecast(Request request)
        {
            return _proxy.ShowRiskAndForecast(request);
        }

        public Response ShowSchedule(Request request)
        {
            return _proxy.ShowSchedule(request);
        }

        public Response SyncExchangeRates(Request request)
        {
            return _proxy.SyncExchangeRates(request);
        }

        public Response ShowResult(Request request)
        {
            return _proxy.ShowResult(request);
        }

        public Response ShowTicketResult(Request request)
        {
            return _proxy.ShowTicketResult(request);
        }        
    }
}