Feature: EditingBook
    I want to test editing a book.

Background:
    When I open page "Identity/Account/Login"
    * I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/Index"
    * I press element with name "book-name"
    * I am waiting for "500" milliseconds
    * I press element with id "edit-book"
    * I am waiting for "1000" milliseconds

@success
@admin
Scenario: Successful check editing a book as administrator
    When I enter "D:\7 семак\РиСПСиИТ\_курсач\Books\Изучаем C Sharp. 3-е издание\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\_курсач\Books\Изучаем C Sharp. 3-е издание\0.pdf" in element with id "book-file"
    * I enter "book-name changed" in element with id "book-name"
    * I enter "authors changed" in element with id "authors"
    * I enter "description changed" in element with id "description"
    * I enter "language changed" in element with id "language"
    * I enter "genre changed" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    * I open page "Home/Index"
    Then I find book with name "book-name changed"
    When I press element with name "book-name changed"
    Then element with id "book-name" has text "book-name changed"
    * element with id "book-authors" has text "authors changed"
    * element with id "book-language" has text "Язык: language changed"
    * element with id "book-genre" has text "Жанр: genre changed"
    * element with id "book-description" has text "description changed"

@fail
@admin
Scenario: Error when editing without book name
    When I enter "" in element with id "book-name"
    * I enter "authors changed" in element with id "authors"
    * I enter "description changed" in element with id "description"
    * I enter "language changed" in element with id "language"
    * I enter "genre changed" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    Then element with id "name-validation" has text "Поле Название является обязательным."

@fail
@admin
Scenario: Error when editing without book authors
    When I enter "book-name changed" in element with id "book-name"
    * I enter "" in element with id "authors"
    * I enter "description changed" in element with id "description"
    * I enter "language changed" in element with id "language"
    * I enter "genre changed" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    Then element with id "authors-validation" has text "Поле Авторы является обязательным."

@fail
@admin
Scenario: Error when editing without book description
    When I enter "book-name changed" in element with id "book-name"
    * I enter "authors changed" in element with id "authors"
    * I enter "" in element with id "description"
    * I enter "language changed" in element with id "language"
    * I enter "genre changed" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    Then element with id "description-validation" has text "Поле Описание является обязательным."

@fail
@admin
Scenario: Error when editing without book language
    When I enter "book-name changed" in element with id "book-name"
    * I enter "authors changed" in element with id "authors"
    * I enter "description changed" in element with id "description"
    * I enter "" in element with id "language"
    * I enter "genre changed" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    Then element with id "language-validation" has text "Поле Язык является обязательным."

@fail
@admin
Scenario: Error when editing without book genre
    When I enter "book-name changed" in element with id "book-name"
    * I enter "authors changed" in element with id "authors"
    * I enter "description changed" in element with id "description"
    * I enter "language changed" in element with id "language"
    * I enter "" in element with id "genre"
    * I am submitting a form with id "edit-book-form"
    Then element with id "genre-validation" has text "Поле Жанр является обязательным."
