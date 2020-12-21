Feature: AddingRole
    I want to test adding a role.

Background:
    When I open page "Identity/Account/Login"

@fail
@anonymous
Scenario: Unsuccessful check adding a role as anonymous
    When I open page "Roles/CreateRole"
    Then I am not on the page "Roles/CreateRole"

@fail
@user
Scenario: Unsuccessful check adding a role as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles/CreateRole"
    Then I am not on the page "Roles/CreateRole"

@success
@admin
Scenario: Successful check adding a role as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles/CreateRole"
    Then I am on the page "Roles/CreateRole"
    When I enter "test role" in element with id "role-name"
    * I am submitting a form with id "create-role-form"
    * I open page "Roles"
    Then I find book with tag "td" and name "test role"

@fail
@admin
Scenario: Error when adding without role name
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Roles/CreateRole"
    Then I am on the page "Roles/CreateRole"
    When I enter "" in element with id "role-name"
    * I am submitting a form with id "create-role-form"
    Then element with id "validation-summary" has text "Поле Новая роль является обязательным."
