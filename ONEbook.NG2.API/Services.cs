using System;
using ONEbook.NG2.API.DTO;
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
        public IResponse SyncCustomers(Request request)
        {         
            return Instance.SyncCustomers(request);
        }

        /// <summary>
        /// Changes users's group commission for member level.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IResponse ChangeUsersGroup(Request request)
        {
            return Instance.ChangeUsersGroup(request);
        }

        /// <summary>
        /// Checks synchronization information of customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IResponse CheckIsSyncCustomers(Request request)
        {
            return Instance.CheckIsSyncCustomers(request);
        }

        /// <summary>
        /// Kick out members when change member's group.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse KickoutMembers(Request request)
        {
            return Instance.KickoutMembers(request);
        }

        /// <summary>
        /// Shows risk and forecast function.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse ShowRiskAndForecast(Request request)
        {
            return Instance.ShowRiskAndForecast(request);
        }
        
        /// <summary>
        /// Sync exchage rates.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse SyncExchangeRates(Request request)
        {
            return Instance.SyncExchangeRates(request);
        }

        /// <summary>
        /// Shows result page.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse ShowResult(Request request)
        {
            return Instance.ShowResult(request);
        }

        /// <summary>
        /// Shows ticket detail result.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse ShowTicketResult(Request request)
        {
            return Instance.ShowTicketResult(request);
        }

        /// <summary>
        /// Create currency to 3rd.
        /// </summary>
        /// <param name="request">Request info.</param>
        /// <returns>Response info.</returns>
        public IResponse CreateCurrency(Request request)
        {
            return Instance.CreateCurrency(request);
        }
    }
}