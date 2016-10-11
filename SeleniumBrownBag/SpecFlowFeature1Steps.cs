using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumBrownBag
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver driver;
        FlightStatusPage flightStatusPage;
        FlightInformationPage flightInfoPage;

        [BeforeScenario]
        public void Initialize()
        {
            string driverPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
            driver = new ChromeDriver(chromeDriverService);
            flightStatusPage = new FlightStatusPage(driver);
        }

        [Given(@"I am on the flight status page")]
        public void GivenIAmOnTheFlightStatusPage()
        {
            flightStatusPage.GotoUrl();
        }
        
        [Given(@"I have entered (.*) as the flight number")]
        public void GivenIHaveEnteredAsTheFlightNumber(string flightNumber)
        {
            flightInfoPage = flightStatusPage.SearchForFlightByNumber(flightNumber);
        }
        
        [When(@"I press continue")]
        public void WhenIPressContinue()
        {
        }
        
        [Then(@"the status should be Complete")]
        public void ThenTheStatusShouldBeComplete()
        {
            string msg = flightInfoPage.GetStatusMessage();
            Assert.IsTrue(msg.Contains("Complete"));
        }
    }
}
