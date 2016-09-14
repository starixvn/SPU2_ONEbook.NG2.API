using ONEbook.NG2.API.Configuration;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Authentication info.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// Initializes the instance of <see cref="Auth"/> class.
        /// </summary>
        public Auth()
        {
            var config = NG2Configuration.Instance;
            Login = config.Login;
            Password = config.Password;
        }

        /// <summary>
        /// Login info to access to 3rd API.
        /// </summary>
        internal string Login { get; set; }

        /// <summary>
        /// Secret token to access to 3rd API.
        /// </summary>
        internal string Password { get; set; }

        /// <summary>
        /// Message site id. NAP is 2000, Alpha is 3000.
        /// </summary>
        public int SiteId { get; set; }
    }
}
