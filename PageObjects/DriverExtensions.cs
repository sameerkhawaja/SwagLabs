using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public static class DriverExtensions
    {
        public static void WaitForElement(this IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
