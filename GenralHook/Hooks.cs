using BDD.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.GenralHook
{
    [Binding]
    public sealed class Hooks 
    {
       
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
            //TODO: implement logic that has to run after executing each scenario
        }

        [BeforeTestRun]
        public void BeforeTestRun()
        {

            Base.IntDriver();


        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun");
        }



    }
}
