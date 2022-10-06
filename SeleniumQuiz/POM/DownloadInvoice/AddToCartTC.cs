using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.DownloadInvoice
{
    [TestClass]
    public class AddToCartTC : BaseClass
    {
        [TestMethod]
        public void UserRegistrationWithValidData()
        {
            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            AddToCart register = new AddToCart();
            register.Addcart("Dont ring the bell, just put it on the doorway!","Ezaan Khan", "3842858235","301", "07", "2028");
            string actual = findElement(By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[10]/a/text()")).Text;
            Assert.AreEqual(" Logged in as ", actual);

        }
    }
}
