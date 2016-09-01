using System;

namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Response info when calling API.
    /// </summary>
    internal class Response : IResponse
    {
        /// <summary>
        /// Initializes the instance of <see cref="Response"/> class.
        /// </summary>
        public Response()
        {
            Result = new Result();
            TimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff tt");
        }

        public string TimeStamp
        {
            get; set;
        }

        /// <summary>
        /// Result info of request.
        /// </summary>
        public IResult Result
        {
            get; set;
        }
    }
}