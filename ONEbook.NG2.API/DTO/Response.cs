namespace ONEbook.NG2.API.DTO
{
    public class Response : BaseTime
    {
        public Response()
        {
            Result = new Result();
        }

        public Result Result { get; internal set; }
    }
}
