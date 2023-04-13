Feature: RestAPI
	Try API tests by Specflow

Scenario: ReadCartSpecflow
	Given Get token
	When Get Cart "1"
	Then Cart contains ""title":"Total","text""