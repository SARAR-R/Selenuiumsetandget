using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        IWebDriver d = new ChromeDriver();
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Start()
        {
            d.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }

        [Test]
        public void Operation()
        {

            //IWebElement e = d.FindElement(By.Name("q"));
            //e.SendKeys("hi");

            SeleniumSetMethods.SelectDropDown(d, "TitleId", "Mr.", "Id");

            SeleniumSetMethods.Entertext(d, "Initial", "Execute", "Name");

            SeleniumSetMethods.Click(d, "Save", "Name");
        }
        [TearDown]
        public void Clean()
        {
            d.Close();
        }
    }
}
