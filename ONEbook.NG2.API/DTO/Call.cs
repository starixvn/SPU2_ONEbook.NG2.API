using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Calling method information.
    /// </summary>
    public class Call : BaseToken
    {
        /// <summary>
        /// Initializes the instance of <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
            CustIds = new List<int>();
            Currencies = new Dictionary<int, decimal>();
            Language = "en-US";
        }

        /// <summary>
        /// List of customer id.
        /// </summary>
        public IList<int> CustIds { get; set; }

        /// <summary>
        /// User group of member. (a, b, c, d).
        /// </summary>
        public string UserGroup { get; set; }

        /// <summary>
        /// Login Id for each system.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Upline id of customer.
        /// </summary>
        public int UplineId { get; set; }

        /// <summary>
        /// Role id of customer.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Message site id of customer. SMA is null. Member is 4100300.
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// Currency of customer.
        /// Key: CurrencyId.
        /// Value: ExchangeRate (optional).
        /// </summary>
        public IDictionary<int, decimal> Currencies { get; set; }

        /// <summary>
        /// Login system is sub-account or not?.
        /// </summary>
        public bool IsSubAccount { get; set; }

        /// <summary>
        /// Gamble id of ticket.
        /// </summary>
        public long GambleId { get; set; }

        /// <summary>
        /// Current language of system.
        /// </summary>
        public string Language { get; set; }
    }
}
