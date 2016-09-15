namespace ONEbook.NG2.API.DTO.CheckIsSyncCustomer
{
    /// <summary>
    /// Result info mapping with cust id.
    /// </summary>
    public class AccountInfoResult
    {
        /// <summary>
        /// Customer id.
        /// </summary>
        public int ObCustId { get; set; }

        /// <summary>
        /// Is created at 3rd.
        /// </summary>
        public int IsCreated { get; set; }
    }
}