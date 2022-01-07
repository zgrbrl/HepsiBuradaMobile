using HepsiBuradaMobile.AndroidTest.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaMobile.AndroidTest.Page_Objects
{
    class loginOlTest
    {
        AppiumDriver<IWebElement> driver = BeforeHooks.driver;

        IWebElement btnLoginButton => driver.FindElementById("account_icon");
        IWebElement btnUserAccountLogin => driver.FindElementById("llUserAccountLogin");
        IWebElement txtAccountLoginEmail => driver.FindElementById("etLoginEmail");
        IWebElement txtloginPassword => driver.FindElementById("etLoginPassword");
        IWebElement btnLogin => driver.FindElementById("btnLoginLogin");
        IWebElement btnWelcomePageNo => driver.FindElementByXPath("//android.widget.Button[contains(@resource-id,'button1') and @text='TAMAM']");
        IWebElement btnLoginButtonClosePage => driver.FindElementById("btnUserAccountClose");

        public void btnLoginButtonClick()
        {
            btnLoginButton.Click();
        }

        public void btnUserAccountLoginClick()
        {
            btnUserAccountLogin.Click();
        }

        public void txtAccountLoginEmailSendKeys(string email)
        {
            txtAccountLoginEmail.SendKeys(email);
        }

        public void txtloginPasswordSendKeys(string password)
        {
            txtloginPassword.SendKeys(password);
        }

        public void btnLoginClick()
        {
            btnLogin.Click();
        }

        public void btnWelcomePageNoClick()
        {
            btnWelcomePageNo.Click();
        }

        public void btnLoginButtonClosePageClick()
        {
            btnLoginButtonClosePage.Click();
        }
    }
}
