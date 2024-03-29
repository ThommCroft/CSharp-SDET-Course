﻿Feature: Calculator

As a Spartan who is crap at Maths,
I want a calculator that takes numbers,
So I can do maths on them

@HappyPath
Scenario: Addition
	Given I have a calculator
	And I enter 5 and 2 in the calculator
	When I press add
	Then the result should be 7

@HappyPath
Scenario: Subtract
	Given I have a calculator
	And I enter <input1> and <input2> in the calculator
	When I press subtract
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1      | 1      | 0      |
	| 0      | 1      | -1     |
	| 1000   | 1      | 999    |

@HappyPath
Scenario: Multiply
	Given I have a calculator
	And I enter <input1> and <input2> in the calculator
	When I press multiply
	Then the result should be <result>
	Examples:
	| input1 | input2 | result |
	| 1      | 1      | 1      |
	| 2      | 3      | 6      |
	| 9      | 9      | 81     |
	| 5      | -17    | -85    |

@SadPath
Scenario: Divide By Zero
	Given I have a calculator
	And I enter <input1> and 0 in the calculator
	When I press divide
	Then a DivideByZero Exception should thrown
	And the exception should have the message "Cannot Divide By Zero"
	Examples: 
	| input1 |
	| 1      |
	| 6      |
