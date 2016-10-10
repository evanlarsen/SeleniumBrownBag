using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBrownBag
{
    internal abstract class PageBase
    {
        protected readonly IWebDriver driver;
        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void Input(string cssSelector, string input)
        {
            var elem = FindElementByCssSelector(cssSelector);
            elem.SendKeys(input);
        }

        protected void Click(string cssSelector)
        {
            var elem = FindElementByCssSelector(cssSelector);
            elem.Click();
        }

        protected void GoTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        protected string GetText(string cssSelector)
        {
            var elem = FindElementByCssSelector(cssSelector);
            return elem.Text;
        }

        protected IWebElement FindElementByCssSelector(string cssSelector)
        {
            return driver.FindElement(By.CssSelector(cssSelector));
        }
    }
}
