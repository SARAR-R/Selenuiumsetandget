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
        
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Start()
        {
           Propcollections.driver = new ChromeDriver();
            Propcollections.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }

        [Test]
        public void Operation()
        {

            //IWebElement e = Propcollections.driver.FindElement(By.Name("q"));
            //e.SendKeys("hi");

            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            SeleniumSetMethods.Entertext("Initial", "Execute", PropertyType.Name);

            Console.WriteLine("The value of title is " + SeleniumGetMethods.GetTextselect("TitleId", PropertyType.Id));

            Console.WriteLine("Name " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            SeleniumSetMethods.Click("Save", PropertyType.Name);

        }
        [TearDown]
        public void Clean()
        {
            Propcollections.driver.Close();
        }
    }
}
