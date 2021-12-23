using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AvatradeTests.PageObjects;
using AvatradeTests.Utils;

namespace AvatradeTests.Test
{
    [TestFixture]
    public class Tests : CommonConditions
    {
        private const string ExpectedAddition = "TSLA";
        [Test]
        public void AddStockInPortfolio()
        {
            bool main = new MainMenuPageObject(driver).
                SwitchToMyPortfolios().
                SwitchMyWatchlist().
                AddStock(ExpectedAddition);
            Log.Info(main.ToString());
            Assert.IsFalse(main);
        }
        [Test]
        public void DeleteStockInPortfolio()
        {
            var main = new MainMenuPageObject(driver).
                SwitchToMyPortfolios().
                SwitchMyWatchlist().
                DeleteStock();
            Log.Info(main.ToString());
            Assert.IsFalse(main);
        }
    }
}