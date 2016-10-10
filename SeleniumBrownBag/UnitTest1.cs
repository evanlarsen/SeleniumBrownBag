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
            driver.Navigate().GoToUrl("https://m.alaskaair.com/flightstatus/");
            var flightNumberElem = driver.FindElement(By.CssSelector("#FlightNumber"));
            flightNumberElem.SendKeys("454");
            var continueBtn = driver.FindElement(By.CssSelector("input[type=submit]"));
            continueBtn.Click();
            var msgElem = this.driver.FindElement(By.CssSelector(".status-msg"));
            Assert.IsTrue(msgElem.Text.Contains("Completed"), "Flight 454 should have a status of Completed");
        }
    }
}
