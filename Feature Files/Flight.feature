Feature: Flight
Background: Pre-requisites
	Given User is at HomePage

Scenario: Validate you landed on Homepage
	#Given User is at HomePage
	Then Validate the title of the HomePage

Scenario: Validate the available Fights to be displayed for valid input
	#Given User is at HomePage
	And User clicked on Flight option
	When User books the flight with data
	And I provide the From , To , DepartDate , ReturnDate
	| From | To | DepartDate | ReturnDate |
	|  DEL | BOM| 24/01/2019 | 30/01/2019 |
	|  DEL | BLR| 25/01/2019 | 29/01/2019 |
	Then It should display all the available flights on Flight Detail Page
	
Scenario: Validate the number of flights shown for valid data
	#Given User is at HomePage
	And User clicked on Flight option
	When User books the flight and navigates to Flight Detail Page
	Then The count of the flight display should match with number of rows shown on page

Scenario: Validate to select the flights with lowest fair in To & Fro section
	#Given User is at HomePage
	And User clicked on Flight option
	When User books the flight and navigates to Flight Detail Page
	Then User should be able to book the flights with lowest fair in To & Fro section





	