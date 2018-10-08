using SeleniumFirst;
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
            Propcollections.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void Operation()
        {

            //Login to Application

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("Excute", "Auto");
          // EAPageObject pageEA = new EAPageObject();
            pageEA.FillUserform("hi", "Selenium", "automation");
            



            //Initialize the page by calling its reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("Execute");

            page.btnSave.Click();



            ////IWebElement e = Propcollections.driver.FindElement(By.Name("q"));
            ////e.SendKeys("hi");

            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //SeleniumSetMethods.Entertext("Initial", "Execute", PropertyType.Name);

            //Console.WriteLine("The value of title is " + SeleniumGetMethods.GetTextselect("TitleId", PropertyType.Id));

            //Console.WriteLine("Name " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //SeleniumSetMethods.Click("Save", PropertyType.Name);

        }
        [TearDown]
        public void Clean()
        {
            Propcollections.driver.Close();
        }
    }
}
