using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


namespace SeleniumQuiz.POM.AddProductsToCart
{
    public class AddToCart : BaseClass
    {
        By products = By.XPath("//i[@class='material-icons card_travel']");
        By Order = By.XPath("(//a[@data-product-id='1'])[1]");
        By cont = By.XPath("//button[text()='Continue Shopping']");
        By Order2 = By.XPath("(//a[@data-product-id='2'])[1]");
        By cart = By.XPath("//u[text()='View Cart']");

        public void Addcart()
        {
            Click(products);
            HoverNClick(Order);
            Click(cont);
            HoverNClick(Order2);
            Click(cart);
        }
    }

}

   