namespace ONEbook.NG2.API.DTO.CreateAccount
{
    /// <summary>
    /// Response info of request.
    /// </summary>
    public class Response : BaseTime
    {
        /// <summary>
        /// Result info of sync customer request.
        /// </summary>
        public Result Result { get; set; }
    }
}