using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    internal class FlightInformationPage
    {
        readonly IWebDriver driver;
        public FlightInformationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetStatusMessage()
        {
            var statusMsgElem = driver.FindElement(By.CssSelector(".status-msg"));
            return statusMsgElem.Text;
        }
    }
}
