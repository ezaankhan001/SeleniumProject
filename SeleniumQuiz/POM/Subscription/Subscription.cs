using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumQuiz.POM.Subscription
{
    public class Subscription: BaseClass
    {
        By form = By.XPath("//form[@class='searchform']");
        By EmailTab = By.XPath("//input[@id='susbscribe_email']");
        By Subscribe = By.XPath("//button[@id='subscribe']");


        public void Subscribed(string Email)
        {
            ScrollToElement(form);
            Write(EmailTab, Email);
            Click(Subscribe);
        }
    }
}
