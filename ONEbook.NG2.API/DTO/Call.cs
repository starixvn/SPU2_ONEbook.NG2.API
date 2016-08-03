using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    public class Call : BaseToken
    {
        public Call()
        {
            CustIds = new List<int>();
            Currencies = new Dictionary<int, decimal>();
        }

        public IList<int> CustIds { get; set; }

        public string UserGroup { get; set; }
                
        public int UplineId { get; set; }

        public int RoleId { get; set; }

        public int SiteId { get; set; }

        /// <summary>
        /// Currency of customer.
        /// Key: CurrencyId.
        /// Value: ExchangeRate (optional).
        /// </summary>
        public IDictionary<int, decimal> Currencies { get; set; }

        public bool IsSubAccount { get; set; }

        public long GambleId { get; set; }

        public string Language { get; set; }
    }
}
