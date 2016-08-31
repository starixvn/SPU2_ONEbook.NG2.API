using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Token of request or response.
    /// </summary>
    public interface IBaseToken
    {
        /// <summary>
        /// Current request or response token.
        /// </summary>
        string Seq { get; set; }
    }
}