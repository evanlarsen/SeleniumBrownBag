Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a anonymous user
	I want to be find a flight status

@mytag
Scenario: Find flight by flight number
	Given I am on the flight status page
	And I have entered 454 as the flight number
	When I press continue
	Then the status should be Complete
