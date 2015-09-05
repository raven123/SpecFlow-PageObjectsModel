using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.steps
{
    [Binding]
    class AbstractBaseStep
    {
        protected static IWebDriver driver;

        [BeforeTestRun]
        public static IWebDriver setDriver()
        {
            if (driver == null)
            {
                driver = new FirefoxDriver();
            }
            driver.Manage().Window.Maximize();
            return driver;
        }

        [AfterTestRun]
        public static void tearDown()
        {
            driver.Quit();
        }
    }
}
