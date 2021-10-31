using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Selenium
{
    public class Setup
    {
        public static IWebDriver ChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
