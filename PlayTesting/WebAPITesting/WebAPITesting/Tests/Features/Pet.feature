Feature: Pet

A short summary of the feature

@HappyPath
Scenario: 1.1.1 As a Store User, I want to Enter a Pets ID, So that I can view that Pets information
	Given I am a Store User
	When I enter a valid pet "<ID>"
	Then I should see that pet's information
	Examples: 
	| ID                  |
	| 9223372036854024262 |
	| 9223372036854024263 |
	| 9223372036854024264 |

@SadPath
Scenario: 1.1.2 As a Store User, I want to Enter a Pets ID, So that I can view that Pets information
	Given I am a Store User
	When I enter an invalid pet "<ID>"
	Then I receive a 400 error message
	Examples: 
	| ID  |
	|     |
	| 456 |
	| gty |
	| ,./ |

@HappyPath
Scenario: 1.2.1 As a Store User, I want to see a Pets Status, So that I know if it is available or not
	Given I am a Store User
	When I want to see a pet's valid availability status
	Then I am shown that pet's status

@SadPath
Scenario: 1.2.2 As a Store User, I want to see a Pets Status, So that I know if it is available or not
	Given I am a Store User
	When I enter an invalid pet's availability status
	Then I receive a 400 error message

@HappyPath
Scenario: 1.3.1 As a Store Worker, I want to add a new pet to the store, So that we can sell more pets
	Given I am a Worker
	When I create a new pet for the store
	Then I can see that pet is available

@HappyPath
Scenario: 1.4.1 As a Store Worker, I want update Pets information, So that the information is correct
	Given I am a Worker
	When I update a pet's details
	Then I can see the pet's updated details

@HappyPath
Scenario: 1.5.1 As a Store Worker, I want to remove a Pet, So that the Store inventory is up-to-date
	Given I am a Worker
	When I delete a pet from the store by "<petid>"
	Then I should not see that pets details