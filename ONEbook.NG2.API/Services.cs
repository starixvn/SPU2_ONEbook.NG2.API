using System.Web.Http;
using ONEbook.NG2.API.DTO;
using ONEbook.NG2.API.Log;

namespace ONEbook.NG2.API
{
    public class Services
    {
        private static object locker = new object();
        private static HttpConfiguration config = null;

        public Services()
        {
            lock (locker)
            {
                if (object.ReferenceEquals(null, config))
                {
                    config = GlobalConfiguration.Configuration;
                    config.MessageHandlers.Add(new Writer());
                }
            }
        }

        public Response SyncCustomers(Request request)
        {
            return new Response();
        }

        public Response ChangeUsersGroup(Request request)
        {
            return new Response();
        }

        public Response CheckIsSyncCustomers(Request request)
        {
            return new Response();
        }

        public Response KickoutMembers(Request request)
        {
            return new Response();
        }

        public Response ShowRiskAndForecast(Request request)
        {
            return new Response();
        }

        public Response ShowSchedule(Request request)
        {
            return new Response();
        }

        public Response SyncExchangeRates(Request request)
        {
            return new Response();
        }

        public Response ShowResult(Request request)
        {
            return new Response();
        }

        public Response ShowTicketResult(Request request)
        {
            return new Response();
        }
    }
}
