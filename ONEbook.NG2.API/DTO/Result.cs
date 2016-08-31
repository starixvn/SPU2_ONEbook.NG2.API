using System;
using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Result info when calling API.
    /// </summary>
    internal class Result : IResult
    {
        /// <summary>
        /// Initializes the instance of <see cref="Result"/> class.
        /// </summary>
        public Result()
        {
            ResultDetail = new List<IResultDetail>();
            ResultDetail.Add(new ResultDetail());
        }

        public string Seq
        {
            get; set;
        }

        /// <summary>
        /// Result detail of request.
        /// </summary>
        public IList<IResultDetail> ResultDetail
        {
            get; set;
        }
    }
}
