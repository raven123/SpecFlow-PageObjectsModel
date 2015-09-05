Feature: Google search
	In order to see specific items on a particular topic on google Search page
	As an anonymous user
	I would perform search 

@googleSearch
Scenario: Google Search without tabular params
	Given I am on the google home page
	When I perform search with "SpecFlow"
	Then the results with "SpecFlow" should be displayed on the screen
