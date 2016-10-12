using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.CreateAccount
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
        /// Upline id of customer. If current customer is Super then Upline id is Super id.
        /// </summary>
        public int UplineId { get; set; }

        /// <summary>
        /// Role id of customer.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Currency id of customer.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Disabled status of customer, need to pass for RabbitMQ to call RetrySyncCustomers.
        /// </summary>
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Message site id of customer. SMA is 0. Member is 4100300.
        /// </summary>
        public int SiteId
        {
            get
            {
                return Level != 1 ? 0 : 4100300;
            }
        }

        /// <summary>
        /// List of customers need to be synced.
        /// </summary>
        public IList<AccountInfo> AccountArray { get; set; }
    }
}