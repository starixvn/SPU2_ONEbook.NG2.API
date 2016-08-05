namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Token of request or response.
    /// </summary>
    public class BaseToken
    {
        /// <summary>
        /// Token to validate the request or response.
        /// </summary>
        public string Seq { get; internal set; }
    }
}
