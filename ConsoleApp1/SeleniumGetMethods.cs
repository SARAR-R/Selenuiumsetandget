using OpenQA.Selenium;
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
                return d.FindElement(By.Id(e)).Text;
            if (elementtype == "Name")
                return d.FindElement(By.Name(e)).Text;
            else return string.Empty;

        }
           
    }
}
