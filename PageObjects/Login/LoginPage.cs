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

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void FillCredentials()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.UserNameField));

            _driver.FindElement(Locators.UserNameField).SendKeys("standard_user");
            _driver.FindElement(Locators.PasswordField).SendKeys("secret_sauce");
        }

        public void Login()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.LoginButton));

            _driver.FindElement(Locators.LoginButton).Click();
        }

        public bool? DoesErrorMessageExist()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.ErrorContainer));

            return _driver.FindElement(Locators.ErrorContainer).Displayed;
        }

        public bool? DoesErrorMessageContainText(string p0)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.ErrorContainer));
            return _driver.FindElement(Locators.ErrorContainer).Text.Contains(p0);
        }

        public void FillBadCredentials()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.UserNameField));

            _driver.FindElement(Locators.UserNameField).SendKeys("locked_out_user");
            _driver.FindElement(Locators.PasswordField).SendKeys("secret_sauce");
        }
    }
}
