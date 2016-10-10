using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    [TestClass]
    public abstract class TestBase
    {
        protected IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            string driverPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
            driver = new ChromeDriver(chromeDriverService);
        }
    }
}
