using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvatradeTests.PageObjects;
using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.Service;
using System.Text.Json;
using System.IO;

namespace AvatradeTests.Test
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        public IWebDriver driver;
        [SetUp]
        public void StartPageSetup()
        {
            User user = CreatorUser.JoiningMyAccountFromProperty();
            driver = DriverInstance.GetInstance();
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");
            var main = new MainMenuPageObject(driver);
            main.
                SignUp().
                InputLogin(user.Username).
                InputPassword(user.Password);
        }

        [TearDown]
        public void TearDown()
        {
            DriverInstance.CloseBrowser();
        }
    }
}
