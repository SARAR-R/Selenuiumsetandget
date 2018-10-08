using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public enum PropertyType
    {
        Id,
        Name,
        CssName,
        XPath,
       
    }
    class Propcollections
    {
        //Auto-implemented property
        public static IWebDriver driver {get; set;}

    }
}
