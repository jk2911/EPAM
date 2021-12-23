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
        private By NumberOfPromotionBegin = By.XPath("//input[@type='checkbox']");
        private By NumberOfPromotionAfter = By.XPath("//input[@type='checkbox']");
        private By NumberOfPromotion = By.XPath("//input[@type='checkbox']");
        private By ChoosePromotion = By.XPath("//*[@id=\"pf-detail-table\"]/div[1]/table/tbody/tr[1]/td[1]/label");
        private By StockDeleteButton = By.XPath("//*[@id=\"Lead-3-Portfolios-Proxy\"]/main/div/div/div[1]/button");
        private By DeleteCompletionButton = By.XPath("//*[@id=\"myLightboxContainer\"]/section/form/div[2]/button[1]");
        public MyWatchlistPageObject(IWebDriver driver) : base(driver) { }
        public bool AddStock(string promotion)
        {
            int numberOfPromotionBegin = driver.FindElements(NumberOfPromotionBegin).Count;
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(SearchPromotion).Click();
            Log.Info("Click Button Search Promotion");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(InputPromotion).SendKeys(promotion);
            Log.Info("Input promotion");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(AddPromotion).Click();
            Log.Info("Click Promotion To Add To Portfolio");
            System.Threading.Thread.Sleep(1000);
            int numberOfPromotionAfter = driver.FindElements(NumberOfPromotionAfter).Count;
            return numberOfPromotionBegin == numberOfPromotionAfter;
        }
        public bool DeleteStock()
        {
            int numberOfPromotionBegin = driver.FindElements(NumberOfPromotion).Count;
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(ChoosePromotion).Click();
            Log.Info("Choose promotion");
            System.Threading.Thread.Sleep(500);
            driver.FindElement(StockDeleteButton).Click();
            Log.Info("Click Button delete promotion");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(DeleteCompletionButton).Click();
            Log.Info("Click Button confirm");
            System.Threading.Thread.Sleep(1000);
            int numberOfPromotionAfter = driver.FindElements(NumberOfPromotion).Count;
            return numberOfPromotionBegin == numberOfPromotionAfter;
        }
    }
}
