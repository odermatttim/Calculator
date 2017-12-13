Feature: IntegrationUnitTests
	In order to avoid mistakes in the algorithm
	As a developer
	I want to be told the result of different calculations

@mytag
Scenario: Calculation - Simple Valid Operation
	Given I have entered 1 + 2 into the calculator
	When I press Calculate
	Then the result should be 3 on the screen

Scenario: Calculation - Complex Valid Operation
	Given I have entered 4.31 - 30.068 + 0.0002 - 2028 into the calculator
	When I press Calculate
	Then the result should be -2053.7578 on the screen

Scenario: Calculation - Simple Valid Operation including Multiplication
    Given I have entered 1 * 2 into the calculator
    When I press Calculate
    Then the result should be 2 on the screen

Scenario: Calculation - Complex Valid Operation including Multiplication and Division
    Given I have entered 4 / 5 * 55 - 8.2 + 47.2 / 5 * 3 * 6 - 12 - 2.3 into the calculator
    When I press Calculate
    Then the result should be 191.42 on the screen

Scenario: Calculation - Invalid Operation with missing Operator
    Given I have entered 1 2 into the calculator
    When I press Calculate
    Then the result should be null

Scenario: Calculation - Invalid Operation with Parsing Error
    Given I have entered 4a + 19 into the calculator
    When I press Calculate
    Then the result should be null