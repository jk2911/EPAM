using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MyWatchlistPageObject
    {
        private IWebDriver _webDriver;
        private By SearchPromotion  = By.XPath("//div[@data-test='add-symbol-btn']");
        private By InputPromotion  = By.XPath("//div[@id='dropdown-menu']//input[@type='text']");
        private By AddPromotion = By.XPath("//div[text()='TSLA']");
        private By ActualAddition = By.XPath("//a[text()='TSLA']");
        public MyWatchlistPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public MyPortfolioPageObject MyPortfolios(string promotion)
        {
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(SearchPromotion).Click();
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(InputPromotion).SendKeys(promotion);
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(AddPromotion).Click();
            return new MyPortfolioPageObject(_webDriver);
        }
        public string SearchForAddedPromotion()
        {
            System.Threading.Thread.Sleep(1000);
            return _webDriver.FindElement(ActualAddition).Text;
        }
    }
}
