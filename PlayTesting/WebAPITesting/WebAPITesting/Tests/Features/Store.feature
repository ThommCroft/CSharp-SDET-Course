Feature: Store

A short summary of the feature

@HappyPath
Scenario: 2.1.1 As a Store User, I want to find an order by ID, So that I can see the orders details
	Given I am a Store User
	When I search for an order with a valid "<orderid>"
	Then I can view that orders details

@SadPath
Scenario: 2.1.2 As a Store User, I want to find an order by ID, So that I can see the orders details
	Given I am a Store User
	When I search for an order with an invalid "<orderid>"
	Then I receive a 400 error message

@HappyPath
Scenario: 2.2.1 As a Store Worker, I want to see the Store Inventory, So that I know the status of orders
	Given I am a Worker
	When I check the Store Inventory
	Then I can view all order status

@HappyPath
Scenario: 2.3.1 As a Store User, I want to place an order for a pet, So that I can have a pet
	Given I am a Store User
	When I place an order for a pet
	Then an order is made

@HappyPath
Scenario: 2.4.1 As a Store User, I want to delete my order, So that I do not receive a pet
	Given I am a Store User
	When I delete an order with a valid "<orderid>"
	Then That order should no long exist

@SadPath
Scenario: 2.4.2 As a Store User, I want to delete my order, So that I do not receive a pet
	Given I am a Store User
	When I try to delete an order with an invalid "<orderid>"
	Then I receive a 400 error message