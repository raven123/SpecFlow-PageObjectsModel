using NUnit.Framework;
using OpenQA.Selenium;
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
    class GoogleSearchPageSteps : AbstractBaseStep
    {
        
        [Then(@"the results with ""(.*)"" should be displayed on the screen")]
        public void verifySearchResults(string searchKeyword)
        {
            new GoogleSearchResultsPage(driver).verifySearchResults(searchKeyword,Enums.TimeInSeconds.TEN);
        }
    }
}
