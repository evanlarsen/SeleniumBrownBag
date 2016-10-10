using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    internal class FlightStatusPage : PageBase
    {
        public FlightStatusPage(IWebDriver driver) : base(driver) { }

        public void GotoUrl()
        {
            GoTo("https://m.alaskaair.com/flightstatus");
        }

        public FlightInformationPage SearchForFlightByNumber(string flightNumber)
        {
            Input("#FlightNumber", flightNumber);
            Click("input[type=submit]");
            return new FlightInformationPage(driver);
        }
    }
}
