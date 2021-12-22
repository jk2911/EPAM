using AvatradeTests.Model;
using AvatradeTests.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Driver
{
    public class DriverInstance
    {
        private static IWebDriver driver;
        public DriverInstance() { }
        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                switch (SelectBrowser.WithCredentialsFromProperty().BrowserName)
                {
                    case "firefox":
                        var firefoxOptions = new FirefoxOptions();
                        firefoxOptions.AddArguments(SelectBrowser.WithCredentialsFromProperty().StartParametrs);
                        driver = new FirefoxDriver(Directory.GetCurrentDirectory(), firefoxOptions);
                        break;

                    default:
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments(SelectBrowser.WithCredentialsFromProperty().StartParametrs);
                        driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
                        break;
                }
            }
            return driver;
        }
        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}
