using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    internal class FlightInformationPage : PageBase
    {
        public FlightInformationPage(IWebDriver driver) : base(driver) { }

        public string GetStatusMessage()
        {
            return GetText(".status-msg");
        }
    }
}
