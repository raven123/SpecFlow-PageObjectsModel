using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.utilities;

namespace UnitTestProject1.pages
{
    class GoogleSearchResultsPage: AbstractPage
    {
        public GoogleSearchResultsPage(IWebDriver driver)
            : base(driver)
    {
    
    }


        public void verifySearchResults(string searchKeyword,Enums.TimeInSeconds time)
        {
            Assert.True(wrapper.findElement(By.PartialLinkText(searchKeyword), (int)time).Displayed);
        }
    }
}
