namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Base result of each request.
    /// </summary>
    public class BaseResult : BaseToken
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Is success or not of a request.
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return ErrorCode == 0;
            }

            set
            {
                value = ErrorCode == 0;
            }
        }
    }
}