Feature: EditUserRoles
    I want to test editing a user roles.

Background:
    When I open page "Identity/Account/Login"

@fail
@anonymous
Scenario: Unsuccessful check editing a role as anonymous
    When I open page "Roles/UserList"
    Then I am not on the page "Roles/UserList"

@fail
@user
Scenario: Unsuccessful check editing a role as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles/UserList"
    Then I am not on the page "Roles/UserList"

@success
@admin
Scenario: Successful check editing a role as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles/UserList"
    Then I am on the page "Roles/UserList"
    When I click on the link the adjacent column of the element name "test@email.net"
    * I check the checkbox with the class "role" and the name "Admin"
    * I am submitting a form with id "edit-user-roles-form"
    When I open page "Roles/UserList"
    * I click on the link the adjacent column of the element name "test@email.net"
    Then I validate that the checkbox with the class "role" has role "Admin"
