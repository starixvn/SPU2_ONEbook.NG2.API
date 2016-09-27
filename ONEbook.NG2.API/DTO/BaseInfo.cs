using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Base infos of request or response.
    /// </summary>
    public class BaseInfo
    {
        /// <summary>
        /// Initializes the instance of <see cref="BaseInfo"/> class.
        /// </summary>
        public BaseInfo()
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

        /// <summary>
        /// Log id of request.
        /// </summary>
        public long LogId { get; internal set; }
    }
}
