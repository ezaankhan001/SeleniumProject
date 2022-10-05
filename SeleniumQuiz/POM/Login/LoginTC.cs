using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.Login
{
    [TestClass]
    public class LoginTC : BaseClass
    {

        [TestMethod]
        public void UserLoginWithValidData()
        {

            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            string actual = driver.FindElement(By.XPath("//div[@class='col-sm-6']//child::h1")).Text;
            Assert.AreEqual("AutomationExercise", actual);
            LoginClass register = new LoginClass();
            register.LoginFunc("ezaankhan024@gmail.com", "abcdefg@1");
            By verifyText = By.XPath("//b[text() = 'Account Created!']");
            string text = getText(verifyText);
            Assert.AreEqual("Account Created!", text);
        }

    }
}