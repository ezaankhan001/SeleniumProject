using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumQuiz.POM.Logout
{
    public class LogoutClass : BaseClass
    {
        By home = By.XPath("//i[@class='fa fa-home']");
        By Login = By.XPath("//i[@class='fa fa-lock']");
        By EmailAddress = By.Name("email");
        By Password = By.Name("password");
        By SigninButton = By.XPath("//button[text()='Login']");
        By Logout = By.XPath("//i[@class='fa fa-lock']");


        public void LogoutFunction(string emailAddress, string password)
        {
            Assert.IsTrue(IsElementVisible(home));
            Click(Login);
            Write(EmailAddress, emailAddress);
            Write(Password, password);
            Click(SigninButton);
            Click(Logout);
        }
    }
}