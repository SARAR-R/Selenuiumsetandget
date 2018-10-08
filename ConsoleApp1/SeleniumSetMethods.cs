using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {
       public static void Entertext(IWebDriver d, string e, string value, string elementtype)
        {
            if (elementtype == "id")
            d.FindElement(By.Id(e)).SendKeys(value);
            if (elementtype == "Name")
                d.FindElement(By.Name(e)).SendKeys(value);
            if (elementtype == "Xpath")
                d.FindElement(By.XPath(e)).SendKeys(value);
       }
        //click into a button, checkbox, option etc.,
        public static void Click(IWebDriver d, string e,  string elementtype)
        {
            if (elementtype == "id")
                d.FindElement(By.Id(e)).Click();
            if (elementtype == "Name")
                d.FindElement(By.Name(e)).Click(); 
            if (elementtype == "Xpath")
                d.FindElement(By.XPath(e)).Click(); 
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver d, string e, string value, string elementtype)
        {
            if (elementtype == "Id")
           new SelectElement(d.FindElement(By.Id(e))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(d.FindElement(By.Name(e))).SelectByText(value);
            if (elementtype == "Xpath")
                new SelectElement(d.FindElement(By.XPath(e))).SelectByText(value);

        }
    }
}
