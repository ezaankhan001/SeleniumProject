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


namespace SeleniumQuiz.POM.DownloadInvoice
{
    public class AddToCart : BaseClass
    {
        By home = By.XPath("//i[@class='fa fa-home']");
        By products = By.XPath("//i[@class='material-icons card_travel']");
        By Title = By.XPath("//h2[@class='title text-center']");
        By Order = By.XPath("(//a[@data-product-id='1'])[1]");
        By cont = By.XPath("//button[text()='Continue Shopping']");
        By Order2 = By.XPath("(//a[@data-product-id='2'])[1]");
        By cart = By.XPath("//u[text()='View Cart']");
        //By Checkout = By.CssSelector("#do_action > div.container > div > div > a");
        By cartButton = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[3]/a");
        By Checkout = By.CssSelector("#do_action > div.container > div > div > a");
        By text = By.XPath("//textarea[@class='form-control']");
        By placeOrder = By.XPath("//*[@id='cart_items']/div/div[7]/a");
        By card = By.XPath("//input[@name='name_on_card']");
        By cardNumber = By.XPath("//input[@name='card_number']");
        By cvc = By.XPath("//input[@name='cvc']");
        By ExpiryMonth = By.XPath("//input[@name='expiry_month']");
        By ExpiryYear = By.XPath("//input[@name='expiry_year']");
        By Pay = By.Id("//button[@id='submit']");
        By download = By.XPath("//*[@id='form']/div/div/div/a");
        By continueButton = By.XPath("//*[@id='form']/div/div/div/div/a");

        public void Addcart(string textarea, string cardDetails, string cardNum, string cvc1, string month, string year)
        {
            Assert.IsTrue(IsElementVisible(home));
            Click(products);
            ScrollToElement(Title);
            HoverNClick(Order);
            ImplicitWait(2);
            Click(cont);
            HoverNClick(Order2);
            Click(cart);
            Click(cartButton);
            Click(Checkout);
            ScrollToElement(text);
            Write(text,textarea);
            Click(placeOrder);
            Write(card, cardDetails);
            Write(cardNumber, cardNum);
            Write(cvc, cvc1);
            Write(ExpiryMonth, month);
            Write(ExpiryYear, year);
            Click(Pay);
            Click(download);
            ImplicitWait(5);
            Click(continueButton);
        }
    }

}

   