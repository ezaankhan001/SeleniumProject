using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.SignUp
{
    [TestClass]
    public class SignUpTC: BaseClass
    {
        [TestMethod]
        public void UserRegistrationWithValidData()
        {
           
            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            RegisterUser register = new RegisterUser();
            register.RegisterData("ezaan", "ezaankhan024@gmail.com", "abcdefg@1", "24", "9", "1997","Ezaan","Khan", "Contour","Model Town", "Street 78", "Punjab", "Lahore", "54000","03228494340");
        }
    }
}
