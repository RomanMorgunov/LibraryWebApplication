Feature: BookPage
    I want to check if there are elements on a page with a book.

Background:
    When I open page "Identity/Account/Login"

@success
@admin
Scenario: Successful check as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/Index"
    * I press element with class "book-header"
    Then element with id "no-access-to-book-label" does not exist
    * element with id "download-book" exists
    * element with id "delete-book" exists
    * element with id "edit-book" exists

@success
@user
Scenario: Successful check as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/Index"
    * I press element with class "book-header"
    Then element with id "no-access-to-book-label" does not exist
    * element with id "download-book" exists
    * element with id "delete-book" does not exist
    * element with id "edit-book" does not exist

@success
@anonymous
Scenario: Successful check as anonymous
    When I open page "Home/Index"
    * I press element with class "book-header"
    Then element with id "no-access-to-book-label" exists
    * element with id "download-book" does not exist
    * element with id "delete-book" does not exist
    * element with id "edit-book" does not exist
