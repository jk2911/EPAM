using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class PasswordPageObject
    {
        private IWebDriver _webDriver;
        private By inputPassword = By.XPath("//input[@class='password']");
        private By NextBtn = By.XPath("//div[@class='button-container']//button[@id='login-signin']");
        public PasswordPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public PasswordPageObject InputPassword(string password)
        {
            System.Threading.Thread.Sleep(400);
            _webDriver.FindElement(inputPassword).SendKeys(password);
            _webDriver.FindElement(NextBtn).Click();
            return new PasswordPageObject(_webDriver);
        }
    }
}
