using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.Utils;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://exe.ua");
            WebDriverExtensions.ShouldLocate(driver, "https://exe.ua");


        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}