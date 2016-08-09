using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API
{
    /// <summary>
    /// Service for system to interact with 3rd.
    /// </summary>
    public sealed class Services
    {
        private ThirdPartyServices _proxy;

        /// <summary>
        /// Initializes the instance of <see cref="Services"/> class.
        /// </summary>
        public Services()
        {
            _proxy = WrapperServices<ThirdPartyServices>.Wrap();            
        }

        private ThirdPartyServices Instance
        {
            get
            {
                _proxy = _proxy ?? WrapperServices<ThirdPartyServices>.Wrap();
                return _proxy;
            }
        }
                
        /// <summary>
        /// Synchronizes customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Response SyncCustomers(Request request)
        {         
            return Instance.SyncCustomers(request);
        }

        /// <summary>
        /// Changes users's group commission for member level.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Response ChangeUsersGroup(Request request)
        {
            return Instance.ChangeUsersGroup(request);
        }

        /// <summary>
        /// Checks synchronization information of customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Response CheckIsSyncCustomers(Request request)
        {
            return Instance.CheckIsSyncCustomers(request);
        }

        /// <summary>
        /// Kick out members when change member's group.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response KickoutMembers(Request request)
        {
            return Instance.KickoutMembers(request);
        }

        /// <summary>
        /// Shows risk and forecast function.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response ShowRiskAndForecast(Request request)
        {
            return Instance.ShowRiskAndForecast(request);
        }

        /// <summary>
        /// Shows schedule page.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response ShowSchedule(Request request)
        {
            return Instance.ShowSchedule(request);
        }

        /// <summary>
        /// Sync exchage rates.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response SyncExchangeRates(Request request)
        {
            return Instance.SyncExchangeRates(request);
        }

        /// <summary>
        /// Shows result page.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response ShowResult(Request request)
        {
            return Instance.ShowResult(request);
        }

        /// <summary>
        /// Shows ticket detail result.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public Response ShowTicketResult(Request request)
        {
            return Instance.ShowTicketResult(request);
        }        
    }
}