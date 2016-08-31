namespace ONEbook.NG2.API.DTO
{
    /// <summary>
    /// Response info when calling API.
    /// </summary>
    public interface IResponse : IBaseTime
    {
        /// <summary>
        /// Result info of request.
        /// </summary>
        IResult Result { get; set; }
    }
}