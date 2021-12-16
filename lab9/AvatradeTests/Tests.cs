using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AvatradeTests.PageObjects;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private const string TestEmail = "maksgoy2911@gmail.com";
        private const string TestPassword = "EPAMPASS40";
        private const string ExpectedAddition = "TSLA";
        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            _driver.Manage().Window.Maximize();
        }
        [Test]
        public void Authorization()
        {
            var main = new MainMenuPageObject(_driver);
            main.SignUp().InputLogin(TestEmail).InputPassword(TestPassword);
            System.Threading.Thread.Sleep(1000);
            var main1 = new MainMenuPageObject(_driver);
            main1.MyPortfolios().MyWatchlist().MyPortfolios(ExpectedAddition);
            var watchlist = new MyWatchlistPageObject(_driver);
            Assert.AreEqual(watchlist.SearchForAddedPromotion(), ExpectedAddition);
            System.Threading.Thread.Sleep(1000);
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}