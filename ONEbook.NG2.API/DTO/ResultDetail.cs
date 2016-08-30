namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result detail info of request.
    /// </summary>
    public class ResultDetail
    {
        /// <summary>
        /// Identify request is success or not.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Customer id of action.
        /// </summary>
        public int CustId { get; internal set; }

        /// <summary>
        /// Currency id of customer.
        /// </summary>
        public int CurrencyId { get; internal set; }

        /// <summary>
        /// Error code of request.
        /// </summary>
        public int ErrorCode { get; internal set; }

        /// <summary>
        /// Error message of request.
        /// </summary>
        public string ErrorDescription { get; internal set; }

        /// <summary>
        /// Url to load iframe if any.
        /// </summary>
        public string Url { get; internal set; }
    }
}
