using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public abstract class BasePageObject
    {
        protected IWebDriver driver;
        public BasePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
