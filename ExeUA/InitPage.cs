using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private IWebElement btnLogin => driver.FindElement(By.XPath("//a[@href='/login/']"));

        public void ClickLogin() => btnLogin.Click();
    }
}
