Feature: Registration
    I want to register on the site.

Background:
When I open page "Identity/Account/Register"

@success
Scenario: Successful registration
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    * I press element with id "confirm-link"
    Then element with id "email-confirm" has text "Email подтвержден"

@fail
Scenario: Error when register without first name
    When I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "first-name-validation" has text "Поле Имя является обязательным."

@fail
Scenario: Error when register without second name
    When I enter "Петр" in element with id "first-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "second-name-validation" has text "Поле Фамилия является обязательным."

@fail
Scenario: Error when register without birthdate
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "birhdate-validation" has text "Дата рождения не может быть позже текщего момента, и возраст не может превышать 120 лет."

@fail
Scenario: Error when register without email
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "email-validation" has text "Поле Email является обязательным."

@fail
Scenario: Error when register without phone number
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "phone-number-validation" has text "Поле Номер телефона является обязательным."

@fail
Scenario: Error when register without password
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "password-validation" has text "Поле Пароль является обязательным."

@fail
Scenario: Error when register without confirm password
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I am submitting a form with id "register-form"
    Then element with id "confirm-password-validation" has text "Пароли не совпадают."

@fail
Scenario: Error when register with invalid email
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "TheP@ssw0rd" in element with id "password"
    * I enter "TheP@ssw0rd" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "email-validation" has text "Поле Email заполнено неверно."

@fail
Scenario: Error when register with invalid password
    When I enter "Петр" in element with id "first-name"
    * I enter "Гельд" in element with id "second-name"
    * I enter "01.18.1999" in element with id "birthdate"
    * I enter "test@email.net" in element with id "email"
    * I enter "89511069189" in element with id "phone-number"
    * I enter "T" in element with id "password"
    * I enter "T" in element with id "confirm-password"
    * I am submitting a form with id "register-form"
    Then element with id "password-validation" has text "Пароль должен иметь длину от 6 до 100 символов."
