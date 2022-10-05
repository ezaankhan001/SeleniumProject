using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.RegisterUsingExisting
{ 
    public class Existing : BaseClass
    {
    By SignUp = By.XPath("//i[@class='fa fa-lock']");
    By Name = By.Name("name");
    By EmailAddress = By.XPath("//input[@data-qa='signup-email']");
    By registerButton = By.XPath("//button[@data-qa='signup-button']");


    public void RegisteredUser(String name, string emailAddress)
        {
        Click(SignUp);
        Write(Name, name);
        Write(EmailAddress, emailAddress);
        Click(registerButton);

        }
    }
} 
