
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumQuiz.POM.SignUp
{ 
    public class RegisterUser : BaseClass
    {
        By SignUp = By.XPath("//i[@class='fa fa-lock']");
        By Name = By.Name("name");
        By EmailAddress = By.XPath("//input[@data-qa='signup-email']");
        By registerButton = By.XPath("//button[@data-qa='signup-button']");
        By gender = By.Id("id_gender1");
        By pass = By.Id("password");
        By Date = By.Id("days");
        By Month = By.CssSelector("select[data-qa='months']");
        By Year = By.Id("years");
        By Newsletter = By.Id("newsletter");
        By Offers = By.Id("optin");
        By FirstName = By.Id("first_name");
        By LastName = By.Id("last_name");
        By Company = By.Id("company");
        By Address1 = By.Id("address1");
        By Address2 = By.Id("address2");
        By State = By.Id("state");
        By City = By.Id("city");
        By ZipCode = By.Id("zipcode");
        By MobileNumber = By.Id("mobile_number");
        By RegisterationButton = By.XPath("//button[text()='Create Account']");
        By Continue = By.XPath("//a[text()='Continue']");
        By Delete = By.XPath("//i[@class='fa fa-home']");




        public void RegisterData(string fName, string emailAddress, string password, string date, string month, string year,string firstName, string lastName, string company, string address1, string address2, string state, string city, string zipcode, string mobileNumber)
        {
            Click(SignUp);
            //Assert.AreEqual("New User Signup!", driver.Title);
            Write(Name, fName);
            Write(EmailAddress, emailAddress);
            Click(registerButton);
            //Assert.AreEqual("ENTER ACCOUNT INFORMATION", driver.Title);
            Click(gender);
            Write(pass, password);
            dropDown(Date,date);
            dropDown(Month, month);
            dropDown(Year, year);
            Write(FirstName, firstName);
            Write(LastName, lastName);
            Click(Newsletter);
            Click(Offers);
            Write(Company, company);
            Write(Address1, address1);
            Write(Address2, address2);
            Write(State, state);
            Write(City, city);
            Write(ZipCode, zipcode);
            Write(MobileNumber, mobileNumber);
            Click(RegisterationButton);
            Click(Continue);
            Click(Delete);
        }


    }
}
