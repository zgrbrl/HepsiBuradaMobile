using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace HepsiBuradaMobile.AndroidTest.Hooks
{
    [Binding]
    public class BeforeHooks
    {
        public static AppiumDriver<IWebElement> driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("deviceName", "emulator-5554");
            cap.AddAdditionalCapability("platformName", "android");
            cap.AddAdditionalCapability("plarformVersion", "11");
            cap.AddAdditionalCapability("udid", "emulator-5554");
            cap.AddAdditionalCapability("appPackage", "com.pozitron.hepsiburada");
            cap.AddAdditionalCapability("appActivity", "com.hepsiburada.ui.startup.SplashActivity");
            //cap.AddAdditionalCapability("unicodeKeyboard", false);
            //cap.AddAdditionalCapability("resetKeyboard", false);
            cap.AddAdditionalCapability("noReset", true);

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), cap);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
