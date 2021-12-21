using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MainMenuPageObject : BasePageObject
    {
        private By logInBtn = By.XPath("//div[@class='menu-section']//a[@id='header-signin-link']");
        private By myPortfolios = By.XPath("//a[@href='/portfolios']");
        public MainMenuPageObject(IWebDriver driver) : base(driver) { }
        public AuthorizationPageObject SignUp()
        {
            driver.FindElement(logInBtn).Click();
            return new AuthorizationPageObject(driver);
        }
        public MyPortfolioPageObject SwitchToMyPortfolios()
        {
            driver.FindElement(myPortfolios).Click();
            return new MyPortfolioPageObject(driver);
        }
    }
}
