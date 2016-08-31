using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result info when calling API.
    /// </summary>
    public interface IResult : IBaseToken
    {
        /// <summary>
        /// Result detail of response.
        /// </summary>
       IList<IResultDetail> ResultDetail { get; set; }
    }
}
