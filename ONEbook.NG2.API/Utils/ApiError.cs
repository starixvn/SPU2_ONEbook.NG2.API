namespace ONEbook.NG2.API.Utils
{
    internal enum ApiError
    {
        OwApiError = 5001,
        ThirdPartyNetError = 5002,
        ThirdPartyUM = 5003,
        ThirdPartyDBError = 5004,
        AccountExisted = 5005,
        IsKickedOut = 5006,
        ForcedLogout = 5007,
        Exception = 5008,
        RemotingException = 5009,
        RemotingTimeoutException = 5010
    }
}