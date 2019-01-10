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
    public sealed class Flight
    {
        private HomePage home = new HomePage();
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        #region Given
        //[Given(@"User is at HomePage")]
        //public void GivenUserIsAtHomePage()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Given(@"User clicked on Flight option")]
        public void GivenUserClickedOnFlightOption()
        {
            
        }

        #endregion

        #region Then
        [Then(@"Validate the title of the HomePage")]
        public void ThenValidateTheTitleOfTheHomePage()
        {
            Assert.AreSame(home.checkTitle(), "Flight, Cheap Air Tickets , Hotels, Holiday, Trains Package Booking - Yatra.com");


        }

        [Then(@"It should display all the available flights on Flight Detail Page")]
        public void ThenItShouldDisplayAllTheAvailableFlightsOnFlightDetailPage()
        {
           
        }

        [Then(@"The count of the flight display should match with number of rows shown on page")]
        public void ThenTheCountOfTheFlightDisplayShouldMatchWithNumberOfRowsShownOnPage()
        {
            
        }

        [Then(@"User should be able to book the flights with lowest fair in To & Fro section")]
        public void ThenUserShouldBeAbleToBookTheFlightsWithLowestFairInToFroSection()
        {
            
        }

        #endregion


        #region When

        [When(@"User books the flight")]
        public void WhenUserBooksTheFlight()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User books the flight and navigates to Flight Detail Page")]
        public void WhenUserBooksTheFlightAndNavigatesToFlightDetailPage()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I provide the From , To , DepartDate , ReturnDate")]
        public void WhenIProvideTheFromToDepartDateReturnDate(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User books the flight with data")]
        public void WhenUserBooksTheFlightWithData()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion


    }
}
