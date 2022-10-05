using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.Place_Order
{
    [TestClass]
    public class PlaceOrderTC:BaseClass
    {

    [TestMethod]
    public void PlaceOrder()
        {
            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");

            //PlaceOrder sub = new PlaceOrder();
            //sub.Cart();

            //string actual1 = driver.FindElement(By.XPath("")).Text;
            //Assert.AreEqual("You have been successfully subscribed!", actual);

        }

    }
}
