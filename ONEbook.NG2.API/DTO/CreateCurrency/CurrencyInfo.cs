namespace ONEbook.NG2.API.DTO.CreateCurrency
{
    /// <summary>
    /// Currency info.
    /// </summary>
    public class CurrencyInfo
    {
        /// <summary>
        /// Currency id.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Currency name.
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Exchange rate.
        /// </summary>
        public decimal ExchangeRate { get; set; }
    }
}