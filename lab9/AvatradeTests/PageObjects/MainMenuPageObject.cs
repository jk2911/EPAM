using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        private By logInBtn = By.XPath("//div[@class='menu-section']//a[@id='header-signin-link']");
        private By myPortfolios = By.XPath("//a[@href='/portfolios']");
        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public AuthorizationPageObject SignUp()
        {
            _webDriver.FindElement(logInBtn).Click();
            return new AuthorizationPageObject(_webDriver);
        }
        public MyPortfolioPageObject MyPortfolios()
        {
            _webDriver.FindElement(myPortfolios).Click();
            return new MyPortfolioPageObject(_webDriver);
        }
    }
}
