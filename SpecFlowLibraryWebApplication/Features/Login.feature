Feature: Login
    I want to log in to the site.

Background:
    When I open page "Identity/Account/Login"

@success
@admin
Scenario: Successful login as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    Then element with id "login-name" has text "Привет rom4ik9994@gmail.com!"
    * element with id "logout" exists
    * element with id "add-book" exists
    * element with id "roles" exists

@success
@user
Scenario: Successful login as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    Then element with id "login-name" has text "Привет vip.roman99@mail.ru!"
    * element with id "logout" exists
    * element with id "add-book" does not exist
    * element with id "roles" does not exist

@fail
Scenario: Unsuccessful login
    When I enter "WrongEmail@gmail.com" in element with id "email"
    * I enter "WrongPassword!!" in element with id "password"
    * I press element with id "login"
    Then element with id "validation-summary" has text "Неудачная попытка входа."
