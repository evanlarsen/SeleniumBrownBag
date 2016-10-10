using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Chrome;

namespace SeleniumBrownBag
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            string driverPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
            driver = new ChromeDriver(chromeDriverService);
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://google.com/");
        }
    }
}
