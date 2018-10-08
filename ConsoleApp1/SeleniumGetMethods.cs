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
        public static string GetText(IWebDriver d,String e, string elementtype)
        {
            if (elementtype == "Id")
                return d.FindElement(By.Id(e)).GetAttribute("value");
            if (elementtype == "Name")
                return d.FindElement(By.Name(e)).GetAttribute("value");
            else return string.Empty;

        }

        public static string GetTextselect(IWebDriver d, String e, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(d.FindElement(By.Id(e))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(d.FindElement(By.Name(e))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;

        }

    }
}
