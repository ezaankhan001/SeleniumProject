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
    By home = By.XPath("//i[@class='fa fa-home']");
    By SignUp = By.XPath("//i[@class='fa fa-lock']");
    By Name = By.Name("name");
    By EmailAddress = By.XPath("//input[@data-qa='signup-email']");
    By registerButton = By.XPath("//button[@data-qa='signup-button']");
        //By assert = By.XPath("//*[@id='form']/div/div/div[3]/div/form/p");
        By newsignup = By.XPath("//*[@id='form']/div/div/div[3]/div/h2");

        public void RegisteredUser(String name, string emailAddress)
        {
        Assert.IsTrue(IsElementVisible(home));
        Click(SignUp);
        string actual1 = findElement(By.XPath("//*[@id='form']/div/div/div[3]/div/h2")).Text;
        Assert.AreEqual("New User Signup!", actual1);
        Write(Name, name);
        Write(EmailAddress, emailAddress);
        Click(registerButton);
        string actual2 = findElement(By.XPath("//*[@id='form']/div/div/div[3]/div/form/p")).Text;
        Assert.AreEqual("Email Address already exist!", actual2);

        }
    }
} 
