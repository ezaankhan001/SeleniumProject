using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumQuiz.POM.Login
{
    public class LoginClass: BaseClass
        {
            By Login = By.XPath("//i[@class='fa fa-lock']");
            By EmailAddress = By.Name("email");
            By Password = By.Name("password");
            By SigninButton = By.XPath("//button[text()='Login']");
            By Delete = By.XPath("//i[@class='fa fa-home']");


        public void LoginFunc(string emailAddress, string password)
        {
            Click(Login);
            Write(EmailAddress, emailAddress);
            Write(Password, password);
            Click(SigninButton);
            Click(Delete);
        }
    }
}
