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
            TimeStamp = DateTime.Now;
        }

        /// <summary>
        /// Current time stamp of request or response.
        /// </summary>
        public DateTime TimeStamp
        {
            get; internal set;
        }
    }
}
