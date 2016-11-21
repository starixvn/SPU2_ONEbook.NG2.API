using ONEbook.NG2.API.Interface;

namespace ONEbook.NG2.API
{
    /// <summary>
    /// Service for system to interact with 3rd.
    /// </summary>
    public sealed class Services : IThirdPartyServices
    {
        private IThirdPartyServices _service;

        /// <summary>
        /// Initializes the instance of <see cref="Services"/> class.
        /// </summary>
        public Services()
        {
            _service = new ThirdPartyServices();
        }

        private IThirdPartyServices Instance
        {
            get
            {
                _service = _service ?? new ThirdPartyServices();
                return _service;
            }
        }
                
        /// <summary>
        /// Synchronizes customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DTO.CreateAccount.Response SyncCustomers(DTO.CreateAccount.Request request)
        {         
            return Instance.SyncCustomers(request);
        }

        /// <summary>
        /// Checks synchronization information of customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DTO.CheckIsSyncCustomer.Response CheckIsSyncCustomers(DTO.CheckIsSyncCustomer.Request request)
        {
            return Instance.CheckIsSyncCustomers(request);
        }

        /// <summary>
        /// Shows risk and forecast function.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public DTO.ShowRiskAndForecast.Response ShowRiskAndForecast(DTO.ShowRiskAndForecast.Request request)
        {
            return Instance.ShowRiskAndForecast(request);
        }
        
        /// <summary>
        /// Sync exchage rates.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public DTO.SyncExchangeRate.Response SyncExchangeRates(DTO.SyncExchangeRate.Request request)
        {
            return Instance.SyncExchangeRates(request);
        }

        /// <summary>
        /// Shows result page.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public DTO.ShowResult.Response ShowResult(DTO.ShowResult.Request request)
        {
            return Instance.ShowResult(request);
        }

        /// <summary>
        /// Shows ticket detail result.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public DTO.ShowTicketResult.Response ShowTicketResult(DTO.ShowTicketResult.Request request)
        {
            return Instance.ShowTicketResult(request);
        }

        /// <summary>
        /// Shows parlay details.
        /// </summary>
        /// <param name="request">Request info</param>
        /// <returns>Response info.</returns>
        public DTO.ShowParlayDetail.Response ShowParlayDetail(DTO.ShowParlayDetail.Request request)
        {
            return Instance.ShowParlayDetail(request);
        }

        /// <summary>
        /// Retries sync customers.
        /// </summary>
        /// <param name="request">Create account request.</param>
        /// <returns>Create account response.</returns>
        public DTO.CreateAccount.Response RetrySyncCustomers(DTO.CreateAccount.Request request)
        {
            return _service.RetrySyncCustomers(request);
        }
    }
}