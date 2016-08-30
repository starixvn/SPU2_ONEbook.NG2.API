using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result info when calling API.
    /// </summary>
    public class Result : BaseToken
    {
        /// <summary>
        /// Initializes the instance of <see cref="Result"/> class.
        /// </summary>
        public Result()
        {
            ResultDetail = new List<ResultDetail>();
            ResultDetail.Add(new ResultDetail());
        }

        /// <summary>
        /// Result detail of request.
        /// </summary>
        public IList<ResultDetail> ResultDetail { get; set; }
    }
}
