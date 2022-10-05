using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.Subscription
{
    [TestClass]
    public class SubscriptionTC : BaseClass
    {
        [TestMethod]
        public void Subcripton()
        {
            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            string actual = findElement(By.XPath("//h2[text()='Subscription']")).Text;
            Assert.AreEqual("SUBSCRIPTION", actual);
            Subscription sub = new Subscription();
            sub.Subscribed("ezaan.24khan@gmail.com");

            //string actual1 = findElement(By.XPath("")).Text;
            //Assert.AreEqual("You have been successfully subscribed!", actual);

        }
    }
}
