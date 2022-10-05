using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.ScrollUpDown
{
    public class Scroll: BaseClass
    {
        By scrol = By.ClassName("footer-widget");
        By home = By.XPath("//i[@class='fa fa-home']");
        By fullfledge = By.XPath("//h2[text()='Full-Fledged practice website for Automation Engineers']");

        public void scrollingDownUp()
        {
            Assert.IsTrue(IsElementVisible(home));
            ScrollToElement(scrol);
            ImplicitWait(2);
            //scrolling Up
            ScrollToElement(home);
            Assert.IsTrue(IsElementVisible(fullfledge));
        }
    }
}
