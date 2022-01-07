using HepsiBuradaMobile.AndroidTest.Page_Objects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HepsiBuradaMobile.AndroidTest.Step_Definition
{
    [Binding]
    public class LoginTestSteps
    {
        loginOlTest _loginOlTest;

        public LoginTestSteps()
        {
            _loginOlTest = new loginOlTest();
        }


        [Given(@"Account butonuna tıklanır\.")]
        public void GivenAccountButonunaTıklanır_()
        {
            _loginOlTest.btnLoginButtonClick();
        }

        [Given(@"Giriş Yap butonuna tıklanır\.")]
        public void GivenGirisYapButonunaTıklanır_()
        {
            Thread.Sleep(3000);
            _loginOlTest.btnUserAccountLoginClick();
        }

        [Given(@"Eposta bilgisi girilir '(.*)'")]
        public void GivenEpostaBilgisiGirilir(string txtemail)
        {
            _loginOlTest.txtAccountLoginEmailSendKeys(txtemail);
        }

        [Given(@"Parola Girilir\. '(.*)'")]
        public void GivenParolaGirilir_(string txtpossword)
        {
            _loginOlTest.txtloginPasswordSendKeys(txtpossword);
        }

        [Given(@"Güvenli Giriş Butonuna Basılır\.")]
        public void GivenGuvenliGirisButonunaBasılır_()
        {
            _loginOlTest.btnLoginClick();
        }

        [When(@"Alışverişe hoşgeliniz mesajına tamam butonuna basılır\.")]
        public void WhenAlısveriseHosgelinizMesajınaTamamButonunaBasılır_()
        {
            _loginOlTest.btnWelcomePageNoClick();
        }

        [Then(@"kapat butonuna basılır\.")]
        public void ThenKapatButonunaBasılır_()
        {
            _loginOlTest.btnLoginButtonClosePageClick();
        }
    }
}
