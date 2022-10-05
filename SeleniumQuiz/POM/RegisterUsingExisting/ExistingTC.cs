using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.RegisterUsingExisting
{
    [TestClass]
    public class ExistingTC : BaseClass
    {
        [TestMethod]
        public void ExistingUser()
        {
            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            Existing register = new Existing();
            register.RegisteredUser("ezaan", "ezaankhan024@gmail.com");
            
           
        }
    }
}
