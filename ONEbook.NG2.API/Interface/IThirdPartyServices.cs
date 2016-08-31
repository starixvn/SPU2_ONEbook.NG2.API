using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.Interface
{
    public interface IThirdPartyServices
    {
        IResponse SyncCustomers(Request request);

        IResponse ChangeUsersGroup(Request request);

        IResponse CheckIsSyncCustomers(Request request);

        IResponse KickoutMembers(Request request);

        IResponse ShowRiskAndForecast(Request request);

        IResponse SyncExchangeRates(Request request);

        IResponse ShowResult(Request request);

        IResponse ShowTicketResult(Request request);

        IResponse CreateCurrency(Request request);
    }
}