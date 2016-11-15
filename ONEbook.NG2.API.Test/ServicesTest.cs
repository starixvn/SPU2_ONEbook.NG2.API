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
            Fanex.Data.Configuration.DbSettingProviderManager.Current.Start();
        }
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _service = new Services();
            Fanex.Data.Configuration.DbSettingProviderManager.Current.Start();
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
        public void ChangeUsersGroup()
        {
        }

        [Test]
        public void CheckIsSyncCustomers()
        {
        }

        [Test]
        public void KickoutMembers()
        {
        }

        [Test]
        public void ShowRiskAndForecast()
        {
        }

        [Test]
        public void ShowSchedule()
        {
        }

        [Test]
        public void SyncExchangeRates()
        {
        }

        [Test]
        public void ShowResult()
        {
        }

        [Test]
        public void ShowTicketResult()
        {
        }        

        [OneTimeTearDown]
        public void TearDown()
        {
            _service = null;
        }
    }
}