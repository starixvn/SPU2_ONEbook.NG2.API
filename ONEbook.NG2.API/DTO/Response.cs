namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Response info when calling API.
    /// </summary>
    public class Response : BaseTime
    {
        /// <summary>
        /// Initializes the instance of <see cref="Response"/> class.
        /// </summary>
        public Response()
        {
            Result = new Result();
        }

        /// <summary>
        /// Result info of request.
        /// </summary>
        public Result Result { get; set; }
    }
}
