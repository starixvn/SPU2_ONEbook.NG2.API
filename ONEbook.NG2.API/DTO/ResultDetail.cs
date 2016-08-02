namespace ONEbook.NG2.API.DTO
{
    public class ResultDetail
    {
        public bool IsSuccess { get; set; }

        public int CustId { get; set; }

        public int CurrencyId { get; set; }

        public int ErrorCode { get; set; }

        public string ErrorDescription { get; set; }

        public string Url { get; set; }
    }
}
