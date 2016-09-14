namespace ONEbook.NG2.API.DTO.CreateAccount
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
        public bool IsCreated { get; set; }
    }
}