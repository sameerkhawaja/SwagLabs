using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Selenium
{
    public static class Cleanup
    {
        public static void Webdriver(IWebDriver driver)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
