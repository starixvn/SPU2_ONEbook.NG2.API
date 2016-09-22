using ONEbook.NG2.API.Utils;

namespace ONEbook.NG2.API.DTO.CreateAccount
{
    /// <summary>
    /// Result info mapping with cust id.
    /// </summary>
    public class AccountInfoResult : BaseResult
    {
        /// <summary>
        /// Customer id.
        /// </summary>
        public int ObCustId { get; set; }

        /// <summary>
        /// Is created at 3rd.
        /// </summary>
        public int IsCreated { get; set; }

        /// <summary>
        /// Description about the error if any at 3rd.
        /// </summary>
        public string Memo { get; set; }
        
        /// <summary>
        /// Is success or not.
        /// </summary>
        public new bool IsSuccess
        {
            get
            {
                return IsCreated == 1;
            }
        }

        /// <summary>
        /// Error description of an account when creating in 3rd is translated into specified language.
        /// </summary>
        public new string ErrorDescription
        {
            get
            {
                return IsSuccess ? Memo : ApiResourceHelper.GetResource(ApiError.UnspecifiedError.ToString(), "en-US");
            }
        }

        /// <summary>
        /// Error code of an account when creating in 3rd.
        /// </summary>
        public new int ErrorCode
        {
            get
            {
                return IsCreated == 1 ? 0 : (int)ApiError.UnspecifiedError;
            }
        }
    }
}