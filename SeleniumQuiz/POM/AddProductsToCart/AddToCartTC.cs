using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.AddProductsToCart
{
    [TestClass]
    public class AddToCartTC : BaseClass
    {
        [TestMethod]
        public void UserRegistrationWithValidData()
        {

            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
        }
    }
}
