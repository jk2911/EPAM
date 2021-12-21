using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class PasswordPageObject : BasePageObject
    {
        private By inputPassword = By.XPath("//input[@class='password']");
        private By NextBtn = By.XPath("//div[@class='button-container']//button[@id='login-signin']");
        public PasswordPageObject(IWebDriver driver) : base(driver) { }
        public PasswordPageObject InputPassword(string password)
        {
            System.Threading.Thread.Sleep(400);
            driver.FindElement(inputPassword).SendKeys(password);
            driver.FindElement(NextBtn).Click();
            return new PasswordPageObject(driver);
        }
    }
}
