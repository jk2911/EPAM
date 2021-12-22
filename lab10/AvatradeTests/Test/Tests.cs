using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AvatradeTests.PageObjects;

namespace AvatradeTests.Test
{
    [TestFixture]
    public class Tests : CommonConditions
    {
        private const string ExpectedAddition = "TSLA";
        [Test]
        public void AddStockInPortfolio()
        {
            var main = new MainMenuPageObject(driver);
            main.
                SwitchToMyPortfolios().
                SwitchMyWatchlist().
                AddStock(ExpectedAddition);

            var watchlist = new MyWatchlistPageObject(driver);
            Assert.AreEqual(watchlist.SearchForAddedPromotion(), ExpectedAddition);
        }
    }
}