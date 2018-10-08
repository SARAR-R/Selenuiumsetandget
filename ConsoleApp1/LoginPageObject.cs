using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
            {
            PageFactory.InitElements(Propcollections.driver, this);
            }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(String username, string password)
        {
            //Login
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();

            //Return the page object
            return new EAPageObject();
        }
    }
}
