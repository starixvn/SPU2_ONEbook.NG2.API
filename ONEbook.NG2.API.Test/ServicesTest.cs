using Fanex.Data;
using Fanex.Data.CrossCutting.WrappingException;
using Fanex.Data.OldConnectionStringProvider;
using NUnit.Framework;

namespace ONEbook.NG2.API.Test
{
    /// <summary>
    /// Service for system to interact with 3rd.
    /// </summary>
    [TestFixture]
    public class ServicesTest
    {
        private Services _service;

        public ServicesTest()
        {
            _service = new Services();
            DbSettingProviderManager
                .StartNewSession()
                .Use(new OldConnectionStringProvider())
                .UseDefaultDbSettingProvider(resourcePath: "Areas/Logs", enableWatching: true)
                .Use((settingKey, commandTimeout) => new WrappingExceptionObjectDb(settingKey, commandTimeout))
                .Run();
        }
        
        [Test]
        public void SyncCustomers()
        {
            var request = new DTO.CreateAccount.Request();
            request.Auth.SiteId = 2000;
            request.Call.AccountArray.Add(new DTO.CreateAccount.AccountInfo() { ObCustId = 123456 });
            request.Call.CurrencyId = 20;
            request.Call.Level = 4;
            request.Call.UplineId = 123456;

            var result = _service.SyncCustomers(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void RetrySyncCustomers()
        {
            var request = new DTO.CreateAccount.Request();
            request.Auth.SiteId = 2000;
            request.Call.AccountArray.Add(new DTO.CreateAccount.AccountInfo() { ObCustId = 123456 });
            request.Call.CurrencyId = 20;
            request.Call.Level = 4;
            request.Call.UplineId = 123456;

            var result = _service.RetrySyncCustomers(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void CheckIsSyncCustomers()
        {
            var request = new DTO.CheckIsSyncCustomer.Request();
            request.Auth.SiteId = 2000;
            request.Call.AccountArray.Add(new DTO.CheckIsSyncCustomer.AccountInfo() { ObCustId = 123456 });

            var result = _service.CheckIsSyncCustomers(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void ShowRiskAndForecast()
        {
            var request = new DTO.ShowRiskAndForecast.Request();
            request.Auth.SiteId = 2000;

            var result = _service.ShowRiskAndForecast(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }
        
        [Test]
        public void SyncExchangeRates()
        {
            var request = new DTO.SyncExchangeRate.Request();
            request.Auth.SiteId = 2000;
            request.Call.CurrencyArray.Add(new DTO.SyncExchangeRate.CurrencyInfo { CurrencyId = 20, ExchangeRate = 2.222M });

            var result = _service.SyncExchangeRates(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void ShowResult()
        {
            var request = new DTO.ShowResult.Request();
            request.Auth.SiteId = 2000;

            var result = _service.ShowResult(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void ShowTicketResult()
        {
            var request = new DTO.ShowTicketResult.Request();
            request.Auth.SiteId = 2000;

            var result = _service.ShowTicketResult(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }

        [Test]
        public void ShowParlayDetail()
        {
            var request = new DTO.ShowParlayDetail.Request();
            request.Auth.SiteId = 2000;

            var result = _service.ShowParlayDetail(request);

            Assert.AreEqual(result.Result.IsSuccess, true);
        }
    }
}