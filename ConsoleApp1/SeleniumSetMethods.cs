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
       public static void Entertext( string e, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
            Propcollections.driver.FindElement(By.Id(e)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                Propcollections.driver.FindElement(By.Name(e)).SendKeys(value);
            if (elementtype == PropertyType.XPath)
                Propcollections.driver.FindElement(By.XPath(e)).SendKeys(value);
       }
        //click into a button, checkbox, option etc.,
        public static void Click(string e,  PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                Propcollections.driver.FindElement(By.Id(e)).Click();
            if (elementtype == PropertyType.Name)
                Propcollections.driver.FindElement(By.Name(e)).Click();
            if (elementtype == PropertyType.XPath)
                Propcollections.driver.FindElement(By.XPath(e)).Click(); 
        }

        //Selecting a drop down control
        public static void SelectDropDown(string e, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(Propcollections.driver.FindElement(By.Id(e))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(Propcollections.driver.FindElement(By.Name(e))).SelectByText(value);
            if (elementtype == PropertyType.XPath)
                new SelectElement(Propcollections.driver.FindElement(By.XPath(e))).SelectByText(value);

        }
    }
}
