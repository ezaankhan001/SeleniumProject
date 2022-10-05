using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.Place_Order
{
    public class PlaceOrder : BaseClass
    {
        By home = By.XPath("//i[@class='fa fa-home']");
        By products = By.XPath("//i[@class='material-icons card_travel']");
        By Order = By.XPath("(//a[@data-product-id='1'])[1]");
        By cont = By.XPath("//button[text()='Continue Shopping']");
        By Order2 = By.XPath("(//a[@data-product-id='2'])[1]");
        By cart = By.XPath("//u[text()='View Cart']");
        By Checkout = By.CssSelector("#do_action > div.container > div > div > a");
        By register = By.XPath("//*[@id='checkoutModal']/div/div/div[2]/p[2]/a/u");

        public void Cart()
        {
            Assert.IsTrue(IsElementVisible(home));
            Click(Order);
            Assert.IsTrue(IsElementVisible(home));
            Click(products);
            HoverNClick(Order);
            ImplicitWait(2);
            Click(cont);
            HoverNClick(Order2);
            Click(cart);
            Click(Checkout);
            Click(register);

  
        }

    }
}
