using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.utilities;

namespace UnitTestProject1.pages
{
    class AbstractPage
    {
        protected readonly IWebDriver driver;
        protected readonly WebdriverWrapper wrapper;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            wrapper = new WebdriverWrapper(this.driver);
        }
    }
}
