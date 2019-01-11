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
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
            //TODO: implement logic that has to run after executing each scenario
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            Base.IntDriver();


        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun");
        }

        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("Before Step");

        }

        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("After Step");
        }

    }
}
