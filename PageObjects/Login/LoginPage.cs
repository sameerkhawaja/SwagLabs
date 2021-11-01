using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locators = PageObjects.Login.LoginPageLocators;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private const string pageUrl = "https://www.saucedemo.com/";

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToPage()
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }

        public void FillCredentials()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.WaitForElement(Locators.UserNameField);

            _driver.FindElement(Locators.UserNameField).SendKeys(Constants.STANDARDUSERNAME);
            _driver.FindElement(Locators.PasswordField).SendKeys(Constants.STANDARDPASSWORD);
        }

        public void Login()
        {
            _driver.WaitForElement(Locators.LoginButton);

            _driver.FindElement(Locators.LoginButton).Click();
        }

        public bool DoesErrorMessageExist()
        {
            _driver.WaitForElement(Locators.ErrorContainer);
            return _driver.FindElement(Locators.ErrorContainer).Displayed;
        }

        public bool DoesErrorMessageContainText(string errorText)
        {
            _driver.WaitForElement(Locators.ErrorContainer);
            return _driver.FindElement(Locators.ErrorContainer).Text.Contains(errorText);
        }

        public void FillBadCredentials()
        {
            _driver.WaitForElement(Locators.UserNameField);

            _driver.FindElement(Locators.UserNameField).SendKeys(Constants.LOCKEDUSERNAME);
            _driver.FindElement(Locators.PasswordField).SendKeys(Constants.LOCKEDPASSWORD);
        }
    }
}
