using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    internal class FlightStatusPage
    {
        readonly IWebDriver driver;
        public FlightStatusPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GotoUrl()
        {
            driver.Navigate().GoToUrl("https://m.alaskaair.com/flightstatus");
        }

        public FlightInformationPage SearchForFlightByNumber(string flightNumber)
        {
            var flightNumberElem = driver.FindElement(By.CssSelector("#FlightNumber"));
            flightNumberElem.SendKeys(flightNumber);
            var continueBtn = driver.FindElement(By.CssSelector("input[type=submit]"));
            continueBtn.Click();
            return new FlightInformationPage(driver);
        }
    }
}
