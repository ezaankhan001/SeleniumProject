using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumQuiz.POM.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.CheckoutRegister
{
    [TestClass]
    public class CheckoutRegisterTC : BaseClass
    {
        [TestMethod]
        public void RegisterOnCheckout()
        {
            Browsers("chrome");
            OpenURL("https://automationexercise.com");
            RegisterUser register = new RegisterUser();
            CheckoutRegister check = new CheckoutRegister();
            check.checkoutRegisteration("Dont ring the bell, just put it on the doorway!", "Ezaan Khan", "12423422134", "321", "07", "2025");
            register.RegisterData("ezaan", "ezaankhan040@gmail.com", "abcdefg@1", "24", "9", "1997", "Ezaan", "Khan", "Contour", "Model Town", "Street 78", "Punjab", "Lahore", "54000", "03228494340");

            string actual = findElement(By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[10]/a/text()")).Text;
            Assert.AreEqual(" Logged in as ", actual);

        }
    }
}
