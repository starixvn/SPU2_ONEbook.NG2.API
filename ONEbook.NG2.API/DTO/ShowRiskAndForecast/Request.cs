namespace ONEbook.NG2.API.DTO.ShowRiskAndForecast
{
    /// <summary>
    /// Request information.
    /// </summary>
    public class Request : BaseTime
    {
        /// <summary>
        /// Initializes the instance of <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
            Auth = new Auth();
            Call = new Call();
        }

        /// <summary>
        /// Authentication info to access to 3rd.
        /// </summary>
        public Auth Auth { get; set; }

        /// <summary>
        /// Calling method information.
        /// </summary>
        public Call Call { get; set; }
    }
}