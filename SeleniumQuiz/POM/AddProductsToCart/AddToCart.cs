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
        By image = By.XPath("//*[@id='header']/div/div/div/div[1]/div/a/img");
        By products = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[2]/a");
        By text = By.XPath("/html/body/section[2]/div/div/div[2]/div");
        By addtoCart = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[2]/div/a");

        public void Addcart()
        {

        }
    }

}

   