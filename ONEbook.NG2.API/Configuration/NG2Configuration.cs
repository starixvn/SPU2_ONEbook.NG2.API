using System;
using System.Configuration;

namespace ONEbook.NG2.API.Configuration
{
    /// <summary>
    /// NG2 Configuration class.
    /// </summary>
    internal class NG2Configuration : ConfigurationSection
    {
        private static NG2Configuration _instance = null;

        /// <summary>
        /// Creates instance of this class.
        /// </summary>
        public static NG2Configuration Instance
        {
            get
            {
                _instance = _instance ?? ConfigurationManager.GetSection("ONEbook.NG2.API") as NG2Configuration;
                return _instance;
            }
        }

        /// <summary>
        /// Url to connect with 3rd.
        /// </summary>
        [ConfigurationProperty("Url", IsRequired = false)]
        public string Url
        {
            get { return base["Url"] as string; }
        }

        /// <summary>
        /// Login name to login to 3rd.
        /// </summary>
        [ConfigurationProperty("Login", IsRequired = false)]
        public string Login
        {
            get { return base["Login"] as string; }
        }

        /// <summary>
        /// Password to login to 3rd.
        /// </summary>
        [ConfigurationProperty("Password", IsRequired = false)]
        public string Password
        {
            get { return base["Password"] as string; }
        }

        /// <summary>
        /// Debug mode to trace info.
        /// </summary>
        [ConfigurationProperty("Debug", DefaultValue = "0", IsRequired = false)]
        public string Debug
        {
            get { return base["Debug"] as string; }
        }

        /// <summary>
        /// Debug mode to trace info.
        /// </summary>
        [ConfigurationProperty("Success", DefaultValue = "0", IsRequired = false)]
        public string Success
        {
            get { return base["Success"] as string; }
        }

        [ConfigurationProperty("ProductId", DefaultValue = 23, IsRequired = false)]
        public int ProductId
        {
            get { return Convert.ToInt32(base["ProductId"]); }
        }
    }
}
