Feature: Login
	I want to log in to the site and go to account manage page

@success
Scenario: go to account manage page
	Given login page "https://localhost:5001/Identity/Account/Login"
	When I open login page
	* I enter "rom4ik9994@gmail.com" in element with id "email"
	* I enter "HKs498R8tpqKvBK!!" in element with id "password"
	* I press element with id "login"
	* I go to the page "https://localhost:5001/Identity/Account/Manage" page
	Then I'm on the page "https://localhost:5001/Identity/Account/Manage"

#@fail
#Scenario: go to admin login page fail
#	Given open "https://localhost:5001/Identity/Account/Login" page
#	When I login with "admin" user and "admin" password
#	And press element with id "login"
#	Then i have message about error