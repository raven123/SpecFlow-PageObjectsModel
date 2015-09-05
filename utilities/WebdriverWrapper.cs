using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
namespace UnitTestProject1.utilities
{
    class WebdriverWrapper
    {
        private readonly IWebDriver driver;

        public WebdriverWrapper(IWebDriver currentDriver)
        {
            driver = currentDriver;
        }

        public IWebElement findElement(By elementLocator,int timeOutInSeconds)
        {
            if (timeOutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                return wait.Until<IWebElement>((currentDriver) =>
                {
                    return currentDriver.FindElement(elementLocator);
                });
            }
            else
            {
                return driver.FindElement(elementLocator);
            }
        }

        public static ReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(currentDriver => (currentDriver.FindElements(by).Count > 0) ? currentDriver.FindElements(by) : null);
            }
            else
            {
                return driver.FindElements(by);
            }
        }

        public void sendKeys(By elementLocator, string textToSend, int timeOutInseconds)
        {
            findElement(elementLocator, timeOutInseconds).SendKeys(textToSend);
        }

        public void clickElement(By elementLocator, int timeOutInseconds)
        {
            findElement(elementLocator, timeOutInseconds).Click();
        }
    }
}
