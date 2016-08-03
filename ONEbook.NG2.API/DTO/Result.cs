using System.Collections.Generic;

namespace ONEbook.NG2.API.DTO
{
    public class Result : BaseToken
    {
        public Result()
        {
            ResultDetail = new List<ResultDetail>();
        }

        public IList<ResultDetail> ResultDetail { get; internal set; }
    }
}
