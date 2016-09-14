using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.ShowParlayDetail
{
    /// <summary>
    /// Calling show parlay api params.
    /// </summary>
    public class Call : BaseToken
    {
        /// <summary>
        /// 3rd transaction id.
        /// </summary>
        public string TransactionId { get; set; }
    }
}