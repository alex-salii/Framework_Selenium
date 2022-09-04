using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void NegativeLogin()
        {
            InitPage init = new InitPage(driver);
            
            init.ClickLogin();
            Thread.Sleep(2000);

            LoginPage login = new LoginPage(driver);
            login.SendTextToEmail("test@ttt.com");
            login.SendTextToPassword("password");
            Thread.Sleep(1000);
            login.ClickButton();
            Thread.Sleep(1000);

            string actualError = login.GetErrorMessage();
            string expectedError = "Неправильное имя пользователя или пароль.";
            Assert.AreEqual(actualError, expectedError);

        }
    }
}
