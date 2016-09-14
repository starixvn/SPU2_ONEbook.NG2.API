using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.SyncExchangeRate
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
            CurrencyArray = new List<CurrencyInfo>();
        }

        /// <summary>
        /// List of customers need to be synced.
        /// </summary>
        public IList<CurrencyInfo> CurrencyArray { get; set; }
    }
}