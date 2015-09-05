using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.utilities;

namespace UnitTestProject1.pages
{
    class GoogleHomePage: AbstractPage
       
    {
        private static readonly By searchTextBox = By.Name("q");
        private static readonly By searchButton = By.Name("btnG");

        public GoogleHomePage(IWebDriver driver)
            : base(driver)
        {

        }


        public GoogleHomePage setSearchTextBox(string searchKeyword,Enums.TimeInSeconds time)
        {
            wrapper.sendKeys(searchTextBox,searchKeyword,(int)time);
            return new GoogleHomePage(driver);
        }

        public GoogleSearchResultsPage clickSearchButton(Enums.TimeInSeconds time)
        {
            wrapper.clickElement(searchButton, (int)time);
            return new GoogleSearchResultsPage(driver);
        }

    }
}
