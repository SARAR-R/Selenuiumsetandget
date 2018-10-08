using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
   public class SeleniumGetMethods
    {
        public static string GetText(String e, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return Propcollections.driver.FindElement(By.Id(e)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return Propcollections.driver.FindElement(By.Name(e)).GetAttribute("value");
            else return string.Empty;

        }

        public static string GetTextselect(String e, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(Propcollections.driver.FindElement(By.Id(e))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(Propcollections.driver.FindElement(By.Name(e))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;

        }

    }
}
