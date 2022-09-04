using NUnit.Framework;
using PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class SmokeTests : BaseTest
    {
        [Test]
        public void VerifyPageHeaders()
        {
            InitPage init = new InitPage(driver);
            init.ClickContacts();
            ContactsPage contactsPage = new ContactsPage(driver);
            string header = contactsPage.GetTextFromHeader();
            Assert.AreEqual("Контакти" , header , $"Header {header} is not as expected");
            
            contactsPage.ClickDelivery();
            DeliveryPage deliveryPage = new DeliveryPage(driver);
            header = deliveryPage.GetTextFromHeader();
            Assert.AreEqual("Доставка і оплата", header, $"Header {header} is not as expected");

            deliveryPage.ClickWarranty();
            WarrantyPage warrantyPage = new WarrantyPage(driver);
            header = warrantyPage.GetTextFromHeader();
            Assert.AreEqual("Гарантія та сервіс", header, $"Header {header} is not as expected");

            warrantyPage.ClickCertificates();
            CertificatesPage certificatesPage = new CertificatesPage(driver);
            header = certificatesPage.GetTextFromHeader();
            Assert.AreEqual("Сертифікати", header, $"Header {header} is not as expected");

            certificatesPage.ClickBuilding();
            BuildingPage buildingPage = new BuildingPage(driver);
            header = buildingPage.GetTextFromHeader();
            Assert.AreEqual("Збірка ПК", header, $"Header {header} is not as expected");

            buildingPage.ClickSale();
            SalePage salePage = new SalePage(driver);
            header = salePage.GetTextFromHeader();
            Assert.AreEqual("Уцінка", header, $"Header {header} is not as expected");

        }
    }
}
