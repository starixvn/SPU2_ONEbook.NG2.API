namespace ONEbook.NG2.API.DTO
{
    public class Request : BaseTime
    {
        public Request()
        {
            Auth = new Auth();
            Call = new Call();
        }

        public Auth Auth { get; set; }

        public Call Call { get; set; }
    }
}
