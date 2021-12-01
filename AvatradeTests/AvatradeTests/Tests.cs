using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string TestEmail = "maksgoy2911@gmail.com";
        private const string TestPassword = "EPAMPASS40";

        private const string ExpectedDeal = "BTCUSD";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            _driver.Manage().Window.Maximize();

            var logInBtn = _driver.FindElement(By.XPath("//div[@class='menu-section']//a[@id='header-signin-link']"));
            logInBtn.Click();

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var inputEmail = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='login-username']")));
            inputEmail.SendKeys(TestEmail);

            var submitBtn1 = _driver.FindElement(By.XPath("//input[@id='login-signin']"));
            submitBtn1.Click();

            System.Threading.Thread.Sleep(1000);

            var inputPassword = _driver.FindElement(By.XPath("//input[@class='password']"));
            inputPassword.SendKeys(TestPassword);

            var submitBtn = _driver.FindElement(By.XPath("//div[@class='button-container']//button[@id='login-signin']"));
            submitBtn.Click();
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void AddStockInPortfolio()
        {
            var element = "TSLA";

            var submitBtn = _driver.FindElement(By.XPath("//a[@href='/portfolios']"));
            submitBtn.Click();

            System.Threading.Thread.Sleep(2000);

            var submitBtn1 = _driver.FindElement(By.XPath("//a[@href='/portfolio/p_0/view']"));
            submitBtn1.Click();

            System.Threading.Thread.Sleep(1000);

            var submitBtn2 = _driver.FindElement(By.XPath("//div[@data-test='add-symbol-btn']"));
            submitBtn2.Click();

            System.Threading.Thread.Sleep(2000);

            var inputAct = _driver.FindElement(By.XPath("//div[@id='dropdown-menu']//input[@type='text']"));
            inputAct.SendKeys("Tesla");

            System.Threading.Thread.Sleep(2000);

            var submitBtn3 = _driver.FindElement(By.XPath("//div[text()='TSLA']"));
            submitBtn3.Click();

            System.Threading.Thread.Sleep(2000);

            var findElement = _driver.FindElement(By.XPath("//a[@title='Tesla, Inc.']")).Text;

            Assert.AreEqual(element, findElement);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}