using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Token of request or response.
    /// </summary>
    public class BaseToken
    {
        /// <summary>
        /// Initializes the instance of <see cref="BaseToken"/> class.
        /// </summary>
        public BaseToken()
        {
            Seq = Guid.NewGuid().ToString("D");
        }

        /// <summary>
        /// Token to validate the request or response. No need to input.
        /// </summary>
        public string Seq { get; internal set; }        
    }
}