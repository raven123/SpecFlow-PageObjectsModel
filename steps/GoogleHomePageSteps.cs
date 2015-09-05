using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTestProject1.pages;
using UnitTestProject1.utilities;

namespace UnitTestProject1.steps
{
    [Binding]
    class GoogleHomePageSteps : AbstractBaseStep
    {
        [Given(@"I am on the google home page")]
        public void navigateToHomePage()
        {
            driver.Navigate().GoToUrl("http://google.com");
            Assert.AreEqual("Google", driver.Title);
        }

        [When(@"I perform search with ""(.*)""")]
        public void performSearch(string searchKeyword)
        {
            new GoogleHomePage(driver).setSearchTextBox(searchKeyword, Enums.TimeInSeconds.ZERO).clickSearchButton(Enums.TimeInSeconds.FIVE);

        }

    }
}
