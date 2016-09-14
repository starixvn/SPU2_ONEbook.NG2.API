using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.CreateAccount
{
    /// <summary>
    /// Result info of request.
    /// </summary>
    public class Result : BaseResult
    {
        /// <summary>
        /// Initializes instance of <see cref="Result" /> class.
        /// </summary>
        public Result()
        {
            AccountArray = new List<AccountInfoResult>();
        }

        /// <summary>
        /// List of accounts result info.
        /// </summary>
        public IList<AccountInfoResult> AccountArray { get; set; }
    }
}