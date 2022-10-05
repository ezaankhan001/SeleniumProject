using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz.POM.ScrollUpDown
{
    [TestClass]
    public class ScrollTC:BaseClass
    {
        [TestMethod]
        public void ScrollingDownAndUp()
        {

            BaseClass.Browsers("chrome");
            BaseClass.OpenURL("https://automationexercise.com");
            Scroll ss = new Scroll();
            ss.scrollingDownUp();
        }

    }
}
