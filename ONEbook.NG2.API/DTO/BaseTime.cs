using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Time stamp of request or response. DateTime.Now
    /// </summary>
    public class BaseTime
    {
        /// <summary>
        /// Initializes the instance of <see cref="BaseTime"/> class.
        /// </summary>
        public BaseTime()
        {
            TimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff tt");
            Language = "en-US";
        }

        /// <summary>
        /// Current time stamp of request or response. No need to input.
        /// </summary>
        public string TimeStamp
        {
            get; internal set;
        }

        /// <summary>
        /// Current login user id of each system.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Current culture language. ex: en-US, vi-VN,...
        /// </summary>
        public string Language { get; set; }
    }
}
