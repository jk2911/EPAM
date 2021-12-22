using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class AuthorizationPageObject : BasePageObject
    {
        private By inputEmail = By.XPath("//input[@id='login-username']");
        private By NextBtn = By.XPath("//input[@id='login-signin']");
        public AuthorizationPageObject(IWebDriver driver) : base(driver) { }
        public PasswordPageObject InputLogin(string login)
        {
            System.Threading.Thread.Sleep(400);
            driver.FindElement(inputEmail).SendKeys(login);
            driver.FindElement(NextBtn).Click();
            Log.Info("Click button SingInUsername");
            return new PasswordPageObject(driver);
        }
    }
}
