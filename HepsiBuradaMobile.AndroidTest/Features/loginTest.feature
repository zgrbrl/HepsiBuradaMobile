Feature: loginTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@zgrbrl @hepsiburada
Scenario: loginOlTest
	Given Account butonuna tıklanır.
	And Giriş Yap butonuna tıklanır.
	And Eposta bilgisi girilir 'eposta yazılır.'
	And Parola Girilir. 'Şifre yazılır.'
	And Güvenli Giriş Butonuna Basılır.
	When Alışverişe hoşgeliniz mesajına tamam butonuna basılır.
	Then kapat butonuna basılır.