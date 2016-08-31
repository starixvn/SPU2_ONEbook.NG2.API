namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result detail info of request.
    /// </summary>
    public interface IResultDetail
    {
        /// <summary>
        /// Identify request is success or not.
        /// </summary>
        bool IsSuccess { get; set; }

        /// <summary>
        /// Customer id of action.
        /// </summary>
        int CustId { get; set; }

        /// <summary>
        /// Currency id of customer.
        /// </summary>
        int CurrencyId { get; set; }

        /// <summary>
        /// Error code of request.
        /// </summary>
        int ErrorCode { get; set; }

        /// <summary>
        /// Error message of request.
        /// </summary>
        string ErrorDescription { get; set; }

        /// <summary>
        /// Url to load iframe if any.
        /// </summary>
        string Url { get; set; }
    }
}
