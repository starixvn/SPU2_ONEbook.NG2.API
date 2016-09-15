namespace ONEbook.NG2.API.DTO.ShowRiskAndForecast
{
    /// <summary>
    /// Response info of request.
    /// </summary>
    public class Response : BaseTime
    {
        /// <summary>
        /// Initializes an instance of <see cref="Response"/> class.
        /// </summary>
        public Response()
        {
            Result = new Result();
        }

        /// <summary>
        /// Result info of sync customer request.
        /// </summary>
        public Result Result { get; set; }
    }
}