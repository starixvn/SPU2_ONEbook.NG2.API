namespace ONEbook.NG2.API.DTO
{
    public class ResultDetail
    {
        public bool IsSuccess { get; internal set; }

        public int CustId { get; internal set; }

        public int CurrencyId { get; internal set; }

        public int ErrorCode { get; internal set; }

        public string ErrorDescription { get; internal set; }

        public string Url { get; internal set; }
    }
}
