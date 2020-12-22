Feature: RemovingBook
    I want to test removing a book.

@success
@admin
Scenario: Successful check editing a book as administrator
    When I open page "Identity/Account/Login"
    * I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/Index"
    * I press element with name "book-name changed"
    * I am waiting for "500" milliseconds
    * I press element with id "delete-book"
    * I open page "Home/Index"
    Then I cannot find book with name "book-name changed"
