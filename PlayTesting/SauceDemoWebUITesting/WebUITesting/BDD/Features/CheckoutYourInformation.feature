Feature: CheckoutYourInformation

Testing the features of the Checkout: Your Information page

@HappyPath
Scenario: 1.1.7 Entering valid details to continue the checkout process
	Given I am Logged in
	And I am on checkout your information page
	When I enter a valid firstname "<firstname>", lastname "<lastname>" and zip/ postal code "<postalcode>"
	Then I press the continue button
	And I am taken to the checkout overview page
	Examples: 
	| firstname | lastname | postalcode |
	| tom       | croft    | M15 6BH    |
	| derick    | dude     | 10005      |

@HappyPath
Scenario: 1.1.8 Entering an invalid postal code which results in being made to stay on the Checkout: Your Information page
	Given I am Logged in
	And I am on checkout your information page
	When I enter invalid postal code "<postalcode>"
	Then I cannot press the continue button
	And stay on the checkout your information page
	Examples: 
	| postalcode |
	| name       |
	| 1234       |
	| !"£$       |

@SadPath
Scenario: 1.1.9 Not entering details into a field
	Given I am Logged in
	And I am on checkout your information page
	When I do not enter firstname "<firstname>", lastname "<lastname>" or postal code "<postalcode>"
	Then I recieve an error message "<message>"
	Examples: 
	| firstname | lastname | postalcode | message                       |
	|           |          |            | Error: First Name is required |
	|           | name     |            | Error: First Name is required |
	|           | name     | M15 6BH    | Error: First Name is required |
	| firstname |          |            | Error: Last Name is required  |
	| firstname |          | M15 6BH    | Error: Last Name is required  |
	| name      | namename |            | Error: Postal Code is required  |

@HappyPath
Scenario: 2.1.1 Navigating to the Sauce Labs Website
	Given I am Logged in
	And I am on the burger menu
	When I click the about button
	Then I am taken to saucelabs website

@HappyPath
Scenario: 2.2.1 Logging out of my account
	Given I am Logged in
	And I am on the burger menu
	When I click the logout button
	Then I am taken to the login page

@HappyPath
Scenario: 2.3.1 Closing the burger menu with the All Items button
	Given I am Logged in
	And I am on the burger menu
	When I click the all items button
	Then the burger menu should close

@HappyPath
Scenario: 2.3.2 Closing the burger menu with the Red Cross button
	Given I am Logged in
	And I am on the burger menu
	When I click the red cross button
	Then the burger menu should close

@HappyPath
Scenario: 2.4.1 Remove all products from the cart by reseting the Apps state
	Given I am Logged in
	And I am on the burger menu
	When I click the reset button
	Then all products are removed from the cart

@HappyPath
Scenario: 3.1.1 Navigate to the Sauce Labs Twitter page
	Given I am Logged in
	When I click the Twitter button
	Then I am taken to the Sauce Labs Twitter page

@HappyPath
Scenario: 3.2.1 Navigate to the Sauce Labs Facebook page
	Given I am Logged in
	When I click the Facebook button
	Then I am taken to the Sauce Labs Facebook page

@HappyPath
Scenario: 3.3.1 Navigate to the Sauce Labs Linkedin page
	Given I am Logged in
	When I click the Linkedin button
	Then I am taken to the Sauce Labs Linkedin page

@HappyPath
Scenario: 4.1.1 Navigate to the Sauce Labs Terms of Service page
	Given I am Logged in
	When I click the Terms of Service button
	Then I am taken to the Sauce Labs Terms of Service page

@HappyPath
Scenario: 4.2.1 Navigate to the Sauce Labs Privacy Policy page
	Given I am Logged in
	When I click the Privacy policy button
	Then I am taken to the Sauce labs Privacy Policy page