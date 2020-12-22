Feature: RemovingRole
    I want to test removing a role.

Background:
    When I open page "Identity/Account/Login"

@fail
@anonymous
Scenario: Unsuccessful check removing a role as anonymous
    When I open page "Roles"
    Then I am not on the page "Roles"

@fail
@user
Scenario: Unsuccessful check removing a role as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles"
    Then I am not on the page "Roles"

@success
@admin
Scenario: Successful check removing a role as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles"
    Then I am on the page "Roles"
    When I click on the button the adjacent column of the element name "test role"
    * I open page "Roles"
    Then I cannot find book with tag "td" and name "test role"
