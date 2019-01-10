using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.StepDefination
{
    [Binding]
    public sealed class Login
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"User click on Login")]
        public void GivenUserClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"User enter wrong credentials")]
        public void GivenUserEnterWrongCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User should see the error msg from wrong credentials")]
        public void ThenUserShouldSeeTheErrorMsgFromWrongCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User enters valid credentials")]
        public void WhenUserEntersValidCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User able to login successfully\.")]
        public void ThenUserAbleToLoginSuccessfully_()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
