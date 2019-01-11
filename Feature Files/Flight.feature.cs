﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FlightFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Flight.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Flight", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Flight")))
            {
                global::BDD.FeatureFiles.FlightFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 2
#line 3
 testRunner.Given("User is at HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate you landed on Homepage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Flight")]
        public virtual void ValidateYouLandedOnHomepage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate you landed on Homepage", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 2
this.FeatureBackground();
#line 7
 testRunner.Then("Validate the title of the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate the available Fights to be displayed for valid input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Flight")]
        public virtual void ValidateTheAvailableFightsToBeDisplayedForValidInput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the available Fights to be displayed for valid input", null, ((string[])(null)));
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 2
this.FeatureBackground();
#line 11
 testRunner.And("User clicked on Flight option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("User books the flight with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "From",
                        "To",
                        "DepartDate",
                        "ReturnDate"});
            table1.AddRow(new string[] {
                        "DEL",
                        "BOM",
                        "24/01/2019",
                        "30/01/2019"});
            table1.AddRow(new string[] {
                        "DEL",
                        "BLR",
                        "25/01/2019",
                        "29/01/2019"});
#line 13
 testRunner.And("I provide the From , To , DepartDate , ReturnDate", ((string)(null)), table1, "And ");
#line 17
 testRunner.Then("It should display all the available flights on Flight Detail Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate the number of flights shown for valid data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Flight")]
        public virtual void ValidateTheNumberOfFlightsShownForValidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the number of flights shown for valid data", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 2
this.FeatureBackground();
#line 21
 testRunner.And("User clicked on Flight option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("User books the flight and navigates to Flight Detail Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("The count of the flight display should match with number of rows shown on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate to select the flights with lowest fair in To & Fro section")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Flight")]
        public virtual void ValidateToSelectTheFlightsWithLowestFairInToFroSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate to select the flights with lowest fair in To & Fro section", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 2
this.FeatureBackground();
#line 27
 testRunner.And("User clicked on Flight option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("User books the flight and navigates to Flight Detail Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("User should be able to book the flights with lowest fair in To & Fro section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
