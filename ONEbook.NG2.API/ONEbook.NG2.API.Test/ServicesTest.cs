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

        [OneTimeSetUp]
        public void TestSetup()
        {
            _service = new Services();
        }

        [Test]
        public void SyncCustomers()
        {         
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
        public void TestTearDown()
        {
            _service = null;
        }
    }
}