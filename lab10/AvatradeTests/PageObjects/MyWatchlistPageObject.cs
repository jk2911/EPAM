using AvatradeTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MyWatchlistPageObject : BasePageObject
    {
        private By SearchPromotion  = By.XPath("//div[@data-test='add-symbol-btn']");
        private By InputPromotion  = By.XPath("//div[@id='dropdown-menu']//input[@type='text']");
        private By AddPromotion = By.XPath("//*[@id=\"result-quotes-0\"]");
        private By ActualAddition = By.XPath("//a[text()='TSLA']");
        public MyWatchlistPageObject(IWebDriver driver) : base(driver) { }
        public void AddStock(string promotion)
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(SearchPromotion).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(InputPromotion).SendKeys(promotion);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            //wait.Until(webDriver => webDriver.FindElement(AddPromotion).Displayed);
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(AddPromotion).Click();
            Log.Info("Click Promotion To Add To Portfolio");
            return;
        }
        public string SearchForAddedPromotion()
        {
            System.Threading.Thread.Sleep(1000);
            return driver.FindElement(ActualAddition).Text;
        }
    }
}
