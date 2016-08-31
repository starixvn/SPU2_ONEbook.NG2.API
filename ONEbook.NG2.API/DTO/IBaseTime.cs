using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Time stamp of request or response. DateTime.Now
    /// </summary>
    public interface IBaseTime
    {
        /// <summary>
        /// Current request or response time stamp.
        /// </summary>
        DateTime TimeStamp { get; set; }
    }
}
