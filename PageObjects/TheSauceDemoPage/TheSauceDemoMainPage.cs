using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locators = PageObjects.TheSauceDemoPage.TheSauceDemoPageLocators;

namespace PageObjects.TheSauceDemoPage
{
    public class TheSauceDemoMainPage
    {
        public string DemoPageUrl = "https://www.saucedemo.com/inventory.html";

        private readonly IWebDriver _driver;

        public TheSauceDemoMainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool LogoExists()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(Locators.AppLogo));

            return _driver.FindElement(Locators.AppLogo).Displayed;
        }

        public bool LandedOnPage()
        {
            return _driver.Url == DemoPageUrl;
        }
    }
}
