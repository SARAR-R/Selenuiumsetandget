using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
   
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(Propcollections.driver, this);

        }

        [FindsBy(How = How.Id, Using ="TitleId")]
        public IWebElement ddlTitleId{get;set;}

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName{ get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillUserform(string intial, string FirstName, string LastName)
        {
            txtInitial.SendKeys(intial);
            txtFirstName.SendKeys(FirstName);
            txtLastName.SendKeys(LastName);
            btnSave.Click();
        }
    }
}
