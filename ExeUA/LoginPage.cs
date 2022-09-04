using OpenQA.Selenium;
using PageObject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private IWebElement loginInput => driver.FindElement(By.XPath("//input[@name='login']"));
        private IWebElement passwordInput => driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement loginBtn => driver.FindElement(By.XPath("//input[@value='Войти']"));
        private IWebElement errorText => driver.FindElement(By.TagName("em"));

        public void SendTextToEmail(string text) => loginInput.SendKeys(text);
        public void SendTextToPassword(string text) => passwordInput.SendKeys(text);
        public void ClickButton() => loginBtn.Click();
        public string GetErrorMessage() => errorText.Text;
    }
}
