using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webDriver;
        private By inputEmail = By.XPath("//input[@id='login-username']");
        private By NextBtn = By.XPath("//input[@id='login-signin']");
        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public PasswordPageObject InputLogin(string login)
        {
            System.Threading.Thread.Sleep(400);
            _webDriver.FindElement(inputEmail).SendKeys(login);
            _webDriver.FindElement(NextBtn).Click();
            return new PasswordPageObject(_webDriver);
        }
    }
}
