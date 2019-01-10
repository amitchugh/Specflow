using BDD.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.StepDefination
{

    [Binding]
    public sealed class GenericStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        private HomePage home = new HomePage();
        [Given(@"User is at HomePage")]
        public void GivenUserIsAtHomePage()
        {
            
            Assert.AreEqual(home.checkHomePage(), true, "Home page is not loaded");

        }   

    }
}
