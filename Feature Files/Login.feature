Feature: Login

Background: Pre-Requisites
	Given User is at HomePage
	And User click on Login

Scenario: Check the login with In-valid credentials
	#Given User is at HomePage
	#And User click on Login
	But User enter wrong credentials
	Then User should see the error msg from wrong credentials

Scenario: Check the Login with valid credentials
	#Given User is at HomePage
	#And User click on Login
	When User enters valid credentials
	Then User able to login successfully.



