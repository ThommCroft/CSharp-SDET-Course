Feature: User

A short summary of the feature. (Create a shared login steps definitions containing a Store User and Worker login)

@HappyPath
Scenario: 3.1.1 As a Store Worker, I want to get a user by Username, So that I can see my information
	Given I am a Worker
	When I search for a user with a valid "<username>"
	Then I can view that users details
	Examples: 
	| username |
	| tommo    |
	| bobert   |

@SadPath
Scenario: 3.1.2 As a Store Worker, I want to get a user by Username, So that I can see my information
	Given I am a Worker
	When I search for a user with an invalid "<username>"
	Then I receive a 400 error message
	Examples: 
	| username  |
	|           |
	| gibberish |

@HappyPath
Scenario: 3.2.1 As a Store User, I want to be able to Login to the Store, So that I can see my account and place orders
	Given I am a Store User
	When I login with a valid "<username>" and "<password>"
	Then I can see my account
	Examples: 
	| username | password    |
	| tommo    | secure      |
	| bobert   | ultrasecure |

@SadPath
Scenario: 3.2.2 As a Store User, I want to be able to Login to the Store, So that I can see my account and place orders
	Given I am a Store User
	When [I try to login with an invalid "<username>" or "<password>"
	Then I receive a 400 error message
	Examples: 
	| username | password |
	|          |          |
	| gghgh    | rt3      |

@HappyPath
Scenario: 3.3.1 As a Store User, I want to be able to Logout of my account, So that my account details and orders are safe
	Given I am a Store User
	When I logout of my account
	Then My account is safely logged out

@HappyPath
Scenario: 3.4.1 As a New User, I want to create an account, So that I can buy Pets
	Given I am a New User
	When I create an account
	Then I am able to login to my account

@HappyPath
Scenario: 3.5.1 As a Store User, I want to edit my details, So that they are my most up-to-date details
	Given I am a Store User
	When I want to edit my details
	Then I can see my updated details

@HappyPath
Scenario: 3.6.1 As a Store User, I want to delete my account, So that I don't make new orders for pets
	Given I am a Store User
	When I want to delete my account
	Then I should not be able to login to that account