using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumQuiz.POM.Place_Order
{
    public class PlaceOrder : BaseClass
    {
        By Order = By.XPath("(//a[@data-product-id='1'])[1]");



    public void Cart()
    {
        Click(Order);
    }

    }
}
