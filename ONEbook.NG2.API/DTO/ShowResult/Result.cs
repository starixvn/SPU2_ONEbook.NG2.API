using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO.ShowResult
{
    /// <summary>
    /// Result info of request.
    /// </summary>
    public class Result : BaseResult
    {
        /// <summary>
        /// Url to load iframe to view result.
        /// </summary>
        public string Url { get; set; }
    }
}