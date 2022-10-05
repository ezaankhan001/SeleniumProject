using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumQuiz
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static object wait;
        public static object Settings { get; set; }

        //fucntion for choosing the desired browser
        public static IWebDriver Browsers(String browser)
        {

            if (browser == "chrome")
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddArguments("start-maximized");
                chromeOption.AddArguments("incognito");
                chromeOption.AddArguments("disable-popup-blocking");
                //chromeOption.AddArguments("headless");
                driver = new ChromeDriver(chromeOption);


                //driver = new ChromeDriver(chromeOption);
            }
            else if (browser == "edge")
            {
                EdgeOptions edgeOption = new EdgeOptions();
                edgeOption.AddArguments("start-maximized");
                edgeOption.AddArguments("-inprivate");
                edgeOption.AddArguments("disable-popup-blocking");
                //edgeOption.AddArguments("headless");
                driver = new EdgeDriver(edgeOption);
            }
            else if (browser == "firefox")
            {
                FirefoxOptions firefoxOption = new FirefoxOptions();
                firefoxOption.AddArguments("start-maximized");
                firefoxOption.AddArguments("newprivate");
                //firefoxOption.AddArguments("disable-popup-blocking");
                driver = new FirefoxDriver(firefoxOption);
            }
            return driver;
        }

        public IWebElement findElement(By by)
        {
            return driver.FindElement(by); 
        }
        //function for writing in any given field
        public void Write(By by, String Value)
        {
            driver.FindElement(by).SendKeys(Value);
        }
        //function for clicking an element
        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        private bool IsElementVisible(By by)
        {
            return (findElement(by).Displayed || findElement(by).Enabled) ? true : false;
        }

        //Function for clearing the field
        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        //function for opening a URL
        public static void OpenURL(String url)
        {
            driver.Url = url;
        }
        //function for hoveing over an elemnent
        public static void Hover(By by)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Perform();
        }
        //function for hovering and then clicking
        public static void HoverNClick(By by)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Click().Perform();
        }

        //function for maximising the screen
        public static void Maximize()

        {
            driver.Manage().Window.Maximize();
        }

        public void dropDown(By by, string value)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByValue(value);
        }

        private bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver)
            .ExecuteScript("return document.readyState")
            .Equals("complete");
        }

        public string getText(By by)
        {
            IWebElement gettext = driver.FindElement(by);
            string text = gettext.GetAttribute("value");
            return text;
        }
        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        public static void Scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("window.scrollBy(argument[0].argument[1]);", value, value1);
            js.ExecuteScript("window.scrollBy(0,600);");
        }
        public static void ScrollToElement(By by)
        {
            var scrollToElement = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }

        public static void ScrollBy(int value, int value1)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(argument[0],argument[1]);", value, value1);
            //js.ExecuteScript("window.scrollBy(0,600);");
        }




    }
}