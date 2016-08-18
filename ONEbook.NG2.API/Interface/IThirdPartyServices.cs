using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.Interface
{
    public interface IThirdPartyServices
    {
        Response SyncCustomers(Request request);

        Response ChangeUsersGroup(Request request);

        Response CheckIsSyncCustomers(Request request);

        Response KickoutMembers(Request request);

        Response ShowRiskAndForecast(Request request);
        
        Response SyncExchangeRates(Request request);

        Response ShowResult(Request request);

        Response ShowTicketResult(Request request);
    }
}