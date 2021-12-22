using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MyPortfolioPageObject : BasePageObject
    {
        private By myWatchlist = By.XPath("//a[@href='/portfolio/p_0/view']");
        public MyPortfolioPageObject(IWebDriver driver) : base(driver) { }
        public MyWatchlistPageObject SwitchMyWatchlist()
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(myWatchlist).Click();
            Log.Info("Click button MyWatchlist");
            return new MyWatchlistPageObject(driver);
        }
    }
}
