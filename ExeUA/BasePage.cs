using OpenQA.Selenium;

namespace PageObject
{
    public class BasePage
    {
        protected static IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebElement btnContacts => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/contacts/']"));
        private IWebElement btnDelivery => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/payment-and-delivery/']"));
        private IWebElement btnWarranty => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/warranty-and-service/']"));
        private IWebElement btnCertificates => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/certificates/']"));
        private IWebElement btnBuilding => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/pc-building/']"));
        private IWebElement btnSale => driver.FindElement(By.XPath("//ul[contains(@class, 'site_menu')]//a[@href='/ua/sale/']"));
        private IWebElement txtHeader => driver.FindElement(By.TagName("h1")); 

        public string GetTextFromHeader() => txtHeader.Text;

        public void ClickContacts() => btnContacts.Click();
        public void ClickDelivery() => btnDelivery.Click();
        public void ClickWarranty() => btnWarranty.Click();
        public void ClickCertificates() => btnCertificates.Click();
        public void ClickBuilding() => btnBuilding.Click();
        public void ClickSale() => btnSale.Click(); 


    }
}