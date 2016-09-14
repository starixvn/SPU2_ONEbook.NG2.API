using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.CheckIsSyncCustomer
{
    /// <summary>
    /// Calling api params.
    /// </summary>
    public class Call : BaseToken
    {
        /// <summary>
        /// Initializes the instance of <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
            AccountArray = new List<AccountInfo>();
        }

        /// <summary>
        /// List of customers need to be synced.
        /// </summary>
        public IList<AccountInfo> AccountArray { get; set; }
    }
}