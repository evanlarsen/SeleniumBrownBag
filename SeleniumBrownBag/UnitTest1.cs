using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumBrownBag
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var flightStatusPage = new FlightStatusPage(driver);
            flightStatusPage.GotoUrl();
            var flightInfoPage = flightStatusPage.SearchForFlightByNumber("454");
            var msg = flightInfoPage.GetStatusMessage();
            Assert.IsTrue(msg.Contains("Completed"), "Flight 454 should have a status of Completed");
        }
    }
}
