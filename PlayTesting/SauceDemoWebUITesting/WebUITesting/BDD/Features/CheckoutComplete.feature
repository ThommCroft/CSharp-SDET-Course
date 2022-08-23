Feature: CheckoutComplete

Testing the features of the Checkout: Complete page

@HappyPath
Scenario: 1.1.11 Return to the Products page after a purchase
	Given I am Logged in
	When I am on checkout complete
	Then I can return to the home page

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