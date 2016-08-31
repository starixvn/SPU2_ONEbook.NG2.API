namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result detail info of request.
    /// </summary>
    internal class ResultDetail : IResultDetail
    {
        /// <summary>
        /// Identify request is success or not.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Customer id of action.
        /// </summary>
        public int CustId { get; set; }

        /// <summary>
        /// Currency id of customer.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Error code of request.
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Error message of request.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Url to load iframe if any.
        /// </summary>
        public string Url { get; set; }
    }
}