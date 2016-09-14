namespace ONEbook.NG2.API.Utils
{
    internal enum ApiFunc
    {
        /// <summary>
        /// Synchonizes customer to 3rd.
        /// </summary>
        CreateAccount,
        
        /// <summary>
        /// Gets risk and forecast page url.
        /// </summary>
        ShowRiskAndForecast,

        /// <summary>
        /// Synchronizes exchange rate.
        /// </summary>
        SyncExchangeRate,

        /// <summary>
        /// Checks list of customers are synchronized or not with 3rd.
        /// </summary>
        CheckIsSyncCustomers,

        /// <summary>
        /// Shows result of all sports by date.
        /// </summary>
        ShowResult,

        /// <summary>
        /// Shows ticket result of member.
        /// </summary>
        ShowTicketResult,

        /// <summary>
        /// Creates currency.
        /// </summary>
        CreateCurrency,

        /// <summary>
        /// Show detail tickets of Parlay.
        /// </summary>
        ShowParlayDetail
    }
}