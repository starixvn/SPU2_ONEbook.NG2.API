namespace ONEbook.NG2.API.Interface
{
    /// <summary>
    /// Third party service.
    /// </summary>
    public interface IThirdPartyServices
    {
        /// <summary>
        /// Retries sync customers.
        /// </summary>
        /// <param name="request">Create account request.</param>
        /// <returns>Create account response.</returns>
        DTO.CreateAccount.Response RetrySyncCustomers(DTO.CreateAccount.Request request);

        /// <summary>
        /// Sync customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.CreateAccount.Response SyncCustomers(DTO.CreateAccount.Request request);

        /// <summary>
        /// Check is sync customers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.CheckIsSyncCustomer.Response CheckIsSyncCustomers(DTO.CheckIsSyncCustomer.Request request);

        /// <summary>
        /// Show risk and forecast.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.ShowRiskAndForecast.Response ShowRiskAndForecast(DTO.ShowRiskAndForecast.Request request);

        /// <summary>
        /// Sync exchange rate.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.SyncExchangeRate.Response SyncExchangeRates(DTO.SyncExchangeRate.Request request);

        /// <summary>
        /// Show result page.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.ShowResult.Response ShowResult(DTO.ShowResult.Request request);

        /// <summary>
        /// Show ticket result.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.ShowTicketResult.Response ShowTicketResult(DTO.ShowTicketResult.Request request);

        /// <summary>
        /// Show parlay detail.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        DTO.ShowParlayDetail.Response ShowParlayDetail(DTO.ShowParlayDetail.Request request);
    }
}