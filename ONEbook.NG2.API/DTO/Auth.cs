namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Authentication info.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// Login info to access to 3rd API.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Secret token to access to 3rd API.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Message site id. SMA is empty. Member is 4100300.
        /// </summary>
        public string SiteId { get; set; }
    }
}
