using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Locators = PageObjects.TheSauceDemoPage.TheSauceDemoPageLocators;

namespace PageObjects.TheSauceDemoPage
{
    public class TheSauceDemoMainPage
    {
        public string pageUrl = "https://www.saucedemo.com/inventory.html";

        private readonly IWebDriver _driver;

        public TheSauceDemoMainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool DoesLogoExist()
        {
            _driver.WaitForElement(Locators.AppLogo);

            return _driver.FindElement(Locators.AppLogo).Displayed;
        }

        public bool DidUserLandOnPage()
        {
            return _driver.Url == pageUrl;
        }
    }
}