using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvatradeTests.PageObjects;

namespace AvatradeTests.Test
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        public IWebDriver driver;
        public const string TestEmail = "maksgoy2911@gmail.com";
        public const string TestPassword = "EPAMPASS40";
        [SetUp]
        public void StartPageSetup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            driver.Manage().Window.Maximize();
            var main = new MainMenuPageObject(driver);
            main.SignUp().InputLogin(TestEmail).InputPassword(TestPassword);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
