using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.Logout
{
    [TestClass]
    public class LogoutTC : BaseClass
    {

        [TestMethod]
        public void UserLoginWithValidDataAndLogout()
        {

            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            LogoutClass logout = new LogoutClass();
            logout.LogoutFunction("ezaankhan024@gmail.com", "abcdefg@1");
        }

    }
}