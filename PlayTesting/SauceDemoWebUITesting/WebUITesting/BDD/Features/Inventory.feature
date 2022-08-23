Feature: Inventory

Testing the features of the Products page

# Add Inspect Product Name and Image buttons

@HappyPath
Scenario: 1.1.1 Adding a product to the cart
	Given I am Logged in
	And I am on the products page
	When I add a product "<productAddID>" to the cart
	Then the cart icon displays the number of products in the cart
	Examples: 
	| productAddID                    |
	| add-to-cart-sauce-labs-backpack |

@HappyPath
Scenario: 1.1.3 Removing a product from the cart
	Given I am Logged in
	And I am on the products page
	When I remove an product "<productRemoveID>" from the cart
	Then the product should be removed "<productAddID>"
	Examples: 
	| productRemoveID            | productAddID                    |
	| remove-sauce-labs-backpack | add-to-cart-sauce-labs-backpack |

@HappyPath
Scenario: 1.1.4 Navigating to the your cart page
	Given I am Logged in
	And I am on the products page
	When I click the Cart button
	Then I am taken to the your cart page

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