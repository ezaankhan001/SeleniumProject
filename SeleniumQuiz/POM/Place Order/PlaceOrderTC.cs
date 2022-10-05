using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumQuiz.POM.SignUp;
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
            RegisterUser register = new RegisterUser();
            PlaceOrder sub = new PlaceOrder();
            sub.Cart();
            register.RegisterData("ezaan", "ezaankhan020@gmail.com", "abcdefg@1", "24", "9", "1997", "Ezaan", "Khan", "Contour", "Model Town", "Street 78", "Punjab", "Lahore", "54000", "03228494340");




        }

    }
}
