using AvatradeTests.Utils;
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
            Log.Info("Start Authorization");
            return new AuthorizationPageObject(driver);
        }
        public MyPortfolioPageObject SwitchToMyPortfolios()
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(myPortfolios).Click();
            Log.Info("Switch To My Portfolios");
            return new MyPortfolioPageObject(driver);
        }
    }
}
