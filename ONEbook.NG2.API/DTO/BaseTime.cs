using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Time stamp of request or response. DateTime.Now
    /// </summary>
    public class BaseTime : IBaseTime
    {
        /// <summary>
        /// Initializes the instance of <see cref="BaseTime"/> class.
        /// </summary>
        public BaseTime()
        {
            TimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff tt");
        }

        /// <summary>
        /// Current time stamp of request or response.
        /// </summary>
        public string TimeStamp
        {
            get; set;
        }
    }
}
