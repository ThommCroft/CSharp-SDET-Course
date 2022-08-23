Feature: LoginPage

In order to use the website, a user  must log in to the site to view and purchase products.

@HappyPath
Scenario: Logging in with Valid Credentials
	Given I am on the Login Page
	When I enter a valid username and password
	Then I am taken to the store inventory page

@SadPath
Scenario: Attempting to Login with a Locked-out user Credentials
	Given I am on the Login Page
	When I attempt to enter my username and password
	Then I recieve an error message "<message>"
	Examples:
	| message                                             |
	| Epic sadface: Sorry, this user has been locked out. |

@SadPath
Scenario: Attempting to Login with invalid Credentials
	Given I am on the Login Page
	When I attempt to enter my "<username>" and "<password>"
	Then I recieve an error message "<message>"
	Examples:
	| username | password | message                                                                   |
	|          |          | Epic sadface: Username is required                                        |
	| tom      |          | Epic sadface: Password is required                                        |
	| tom      | secure   | Epic sadface: Username and password do not match any user in this service |