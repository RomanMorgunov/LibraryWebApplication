Feature: AddingBook
    I want to test adding a book.

Background:
    When I open page "Identity/Account/Login"

@fail
@anonymous
Scenario: Unsuccessful check adding a book as anonymous
    When I open page "Home/CreateBook"
    Then I am not on the page "Home/CreateBook"

@fail
@user
Scenario: Unsuccessful check adding a book as user
    When I enter "vip.roman99@mail.ru" in element with id "email"
    * I enter "r47qkuDLJFx7F5U!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am not on the page "Home/CreateBook"

@success
@admin
Scenario: Successful check adding a book as administrator
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    * I open page "Home/Index"
    Then I find book with name "book-name"
    When I press element with name "book-name"
    Then element with id "book-name" has text "book-name"
    * element with id "book-authors" has text "authors"
    * element with id "book-language" has text "Язык: language"
    * element with id "book-genre" has text "Жанр: genre"
    * element with id "book-description" has text "description"

@fail
@admin
Scenario: Error when adding without cover image
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "cover-image-validation" has text "Поле Обложка является обязательным."

@fail
@admin
Scenario: Error when adding without book file
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "book-file-validation" has text "Поле Файл является обязательным."

@fail
@admin
Scenario: Error when adding without book name
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "name-validation" has text "Поле Название является обязательным."

@fail
@admin
Scenario: Error when adding without book authors
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "authors-validation" has text "Поле Авторы является обязательным."

@fail
@admin
Scenario: Error when adding without book description
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "language" in element with id "language"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "description-validation" has text "Поле Описание является обязательным."

@fail
@admin
Scenario: Error when adding without book language
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "genre" in element with id "genre"
    * I am submitting a form with id "create-book-form"
    Then element with id "language-validation" has text "Поле Язык является обязательным."

@fail
@admin
Scenario: Error when adding without book genre
    When I enter "rom4ik9994@gmail.com" in element with id "email"
    * I enter "HKs498R8tpqKvBK!!" in element with id "password"
    * I press element with id "login"
    When I open page "Home/CreateBook"
    Then I am on the page "Home/CreateBook"
    When I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.jpg" in element with id "cover-image"
    * I enter "D:\7 семак\РиСПСиИТ\LibraryWebApplication\Books\Читаемый код. Или Программирование как искусство\0.pdf" in element with id "book-file"
    * I enter "book-name" in element with id "book-name"
    * I enter "authors" in element with id "authors"
    * I enter "description" in element with id "description"
    * I enter "language" in element with id "language"
    * I am submitting a form with id "create-book-form"
    Then element with id "genre-validation" has text "Поле Жанр является обязательным."
