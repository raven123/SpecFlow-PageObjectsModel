using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    class StepDefinition
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void step1(int number)
        {
            Console.WriteLine("statement1 executed");
        }

        [When(@"I press add")]
        public void step3()
        {
            Console.WriteLine("statement3 executed");
        }

        [Then(@"the result should be 120 on the screen")]
        public void step4()
        {
            Console.WriteLine("statement4 executed");
        }
    }
}
